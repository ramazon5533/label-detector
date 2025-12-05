using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
// 1. Add Basler Namespace
using Basler.Pylon;

namespace label_detector
{
    public partial class Form1 : Form
    {
        // --- Basler Variables ---
        private Camera camera = null;
        private PixelDataConverter converter = new PixelDataConverter();
        private Bitmap latestFrame = null; // Stores the latest image for saving

        // --- State Variables ---
        private bool isConnected = false;
        private bool isLive = false;
        private bool isCycling = false;

        // Timers
        private System.Windows.Forms.Timer cycleTimer;

        // Data Structures
        private List<TimeSpan[]> breakSchedules = new List<TimeSpan[]>();

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Note: We don't need 'liveViewTimer' anymore because Basler has its own event.

            // Initialize Cycle Timer
            cycleTimer = new System.Windows.Forms.Timer();
            cycleTimer.Tick += CycleTimer_Tick;

            txtSaveFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            UpdateUIState();
            Log("Application Ready. Please connect Basler Camera.");
        }

        #region --- Camera Connection (Basler) ---

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ip = txtIPAddress.Text;

            try
            {
                // Connect to specific IP if provided, otherwise first found
                if (!string.IsNullOrWhiteSpace(ip))
                {
                    Log($"Looking for camera at {ip}...");
                    camera = new Camera(ip);
                }
                else
                {
                    Log("Looking for first available camera...");
                    camera = new Camera(); // Connects to the first camera found
                }

                // Open the connection
                camera.Open();

                // Setup the event for when an image is grabbed
                camera.StreamGrabber.ImageGrabbed += OnImageGrabbed;

                isConnected = true;
                lblStatusLabel.Text = "Status: Connected";
                lblStatusLabel.ForeColor = Color.Green;
                Log($"Connected to {camera.CameraInfo[CameraInfoKey.ModelName]}");

                UpdateUIState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
                Log("Error: " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (camera != null)
                {
                    if (isLive) StopLiveView();

                    camera.Close();
                    camera.Dispose();
                    camera = null;
                }

                isConnected = false;
                lblStatusLabel.Text = "Status: Disconnected";
                lblStatusLabel.ForeColor = Color.Red;
                Log("Camera Disconnected.");
                UpdateUIState();
            }
            catch (Exception ex)
            {
                Log("Disconnect Error: " + ex.Message);
            }
        }

        #endregion

        #region --- Live View Logic (Basler) ---

        private void btnStartLiveView_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;
            StartLiveView();
        }

        private void btnStopLiveView_Click(object sender, EventArgs e)
        {
            StopLiveView();
        }

        private void StartLiveView()
        {
            if (camera == null) return;

            try
            {
                // Start grabbing images continuously using the event strategy
                camera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
                camera.StreamGrabber.Start(GrabStrategy.LatestImages, GrabLoop.ProvidedByStreamGrabber);

                isLive = true;
                Log("Live View Started.");
                UpdateUIState();
            }
            catch (Exception ex)
            {
                Log("Start Error: " + ex.Message);
            }
        }

        private void StopLiveView()
        {
            if (camera == null) return;

            try
            {
                camera.StreamGrabber.Stop();
                isLive = false;
                Log("Live View Stopped.");
                UpdateUIState();
            }
            catch (Exception ex)
            {
                Log("Stop Error: " + ex.Message);
            }
        }

        // --- BASLER CALLBACK: This runs every time the camera sends a frame ---
        private void OnImageGrabbed(object sender, ImageGrabbedEventArgs e)
        {
            IGrabResult result = e.GrabResult;

            try
            {
                if (result.GrabSucceeded)
                {
                    // 1. Convert Basler Raw Data to C# Bitmap
                    Bitmap bitmap = new Bitmap(result.Width, result.Height, PixelFormat.Format32bppRgb);
                    BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

                    // Use Pylon Converter to fill the bitmap data
                    converter.OutputPixelFormat = PixelType.BGRA8packed;
                    converter.Convert(bmpData.Scan0, bmpData.Stride * bitmap.Height, result);
                    bitmap.UnlockBits(bmpData);

                    // 2. Handle Flips
                    // Note: We need to use Invoke because this runs on a background thread
                    this.Invoke(new Action(() =>
                    {
                        if (chkFlipHorizontal.Checked) bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        if (chkFlipVertical.Checked) bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

                        // 3. Display
                        if (picMainResult.Image != null) picMainResult.Image.Dispose();
                        picMainResult.Image = (Bitmap)bitmap.Clone();

                        // 4. Update 'latestFrame' for saving logic
                        if (latestFrame != null) latestFrame.Dispose();
                        latestFrame = (Bitmap)bitmap.Clone();

                        // 5. Update Stats (Optional, limiting update rate is better for performance)
                        lblFPS.Text = "FPS: Live"; // Real FPS calc can be added here
                    }));

                    bitmap.Dispose(); // Clean up local bitmap
                }
                else
                {
                    Log("Grab Failed: " + result.ErrorCode + " " + result.ErrorDescription);
                }
            }
            catch (Exception ex)
            {
                // Be careful logging here, it can spam errors
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Very Important: Dispose the result to free buffer
                e.DisposeGrabResultIfClone();
            }
        }

        #endregion

        #region --- Saving Logic ---

        // IMPORTANT: Be sure to rename this back to btnSelectSaveFolder_Click_1 if you kept that name in Designer
        private void btnSelectSaveFolder_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtSaveFolder.Text = fbd.SelectedPath;
                    Log($"Save folder changed to: {fbd.SelectedPath}");
                }
            }
        }

        private void btnManualGrab_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;
            CaptureAndSave("Manual");
        }

        private void CaptureAndSave(string prefix)
        {
            if (latestFrame == null)
            {
                Log("No image available to save. (Start Live View first)");
                return;
            }

            try
            {
                // Clone the frame so we don't crash if it updates while saving
                Bitmap bmpToSave = (Bitmap)latestFrame.Clone();

                // Validate Path
                string folderPath = txtSaveFolder.Text;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Save File
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");
                string fileName = $"{prefix}_{timestamp}.jpg";
                string fullPath = Path.Combine(folderPath, fileName);

                bmpToSave.Save(fullPath, ImageFormat.Jpeg);
                bmpToSave.Dispose();

                // UI Updates
                label4.Text = $"Last save: {DateTime.Now:HH:mm:ss}";
                Log($"Saved: {fileName}");

                listSavedFiles.Items.Insert(0, fileName);
                if (listSavedFiles.Items.Count > 50) listSavedFiles.Items.RemoveAt(50);
            }
            catch (Exception ex)
            {
                Log($"Save Error: {ex.Message}");
            }
        }

        #endregion

        #region --- Cycle & Schedule Logic (Same as before) ---

        private void btnStartCycle_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connect camera first!");
                return;
            }

            // Note: For this logic to work, Live View must be running so 'latestFrame' is updating.
            if (!isLive)
            {
                StartLiveView(); // Auto start live view
            }

            int seconds = (int)numIntervalSec.Value;
            int millis = (int)numIntervalMilsec.Value;
            int totalInterval = (seconds * 1000) + millis;

            if (totalInterval <= 0) return;

            cycleTimer.Interval = totalInterval;
            cycleTimer.Start();
            isCycling = true;

            Log($"Cycle Started. Interval: {totalInterval}ms");
            lblStatus.Text = "CURRENT STATUS: RUNNING";
            lblStatus.ForeColor = Color.Green;

            UpdateUIState();
        }

        private void btnStopCycle_Click(object sender, EventArgs e)
        {
            StopCycle();
        }

        private void StopCycle()
        {
            cycleTimer.Stop();
            isCycling = false;

            Log("Cycle Stopped.");
            lblStatus.Text = "CURRENT STATUS: STOPPED";
            lblStatus.ForeColor = Color.Black;
            lblNextCapture.Text = "NEXT CAPTURE: --";

            UpdateUIState();
        }

        private void CycleTimer_Tick(object sender, EventArgs e)
        {
            if (IsCurrentTimeInBreak())
            {
                Log("Cycle skipped (Break Time).");
                lblStatus.Text = "CURRENT STATUS: PAUSED (BREAK)";
                lblStatus.ForeColor = Color.Orange;
                return;
            }

            lblStatus.Text = "CURRENT STATUS: RUNNING";
            lblStatus.ForeColor = Color.Green;

            CaptureAndSave("Auto");

            DateTime nextTime = DateTime.Now.AddMilliseconds(cycleTimer.Interval);
            lblNextCapture.Text = $"NEXT CAPTURE: {nextTime:HH:mm:ss}";
        }

        private bool IsCurrentTimeInBreak()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            foreach (var breakTime in breakSchedules)
            {
                TimeSpan start = breakTime[0];
                TimeSpan end = breakTime[1];
                if (start <= end)
                {
                    if (now >= start && now <= end) return true;
                }
                else
                {
                    if (now >= start || now <= end) return true;
                }
            }
            return false;
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            int startH = (int)numBreakStartHH.Value;
            int startM = (int)numBreakStartMM.Value;
            int endH = (int)numBreakEndHH.Value;
            int endM = (int)numBreakEndMM.Value;

            TimeSpan start = new TimeSpan(startH, startM, 0);
            TimeSpan end = new TimeSpan(endH, endM, 0);

            breakSchedules.Add(new TimeSpan[] { start, end });
            string display = $"{startH:D2}:{startM:D2} ~ {endH:D2}:{endM:D2}";
            listSchedule.Items.Add(display);
            Log($"Added Break: {display}");
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            if (listSchedule.SelectedIndex == -1) return;
            int index = listSchedule.SelectedIndex;
            breakSchedules.RemoveAt(index);
            listSchedule.Items.RemoveAt(index);
            Log("Removed Break Time.");
        }

        #endregion

        #region --- Helpers ---

        private void Log(string message)
        {
            string logEntry = $"[{DateTime.Now:HH:mm:ss}] {message}\r\n";
            txtLog.AppendText(logEntry);
            txtLog.ScrollToCaret();
        }

        private void UpdateUIState()
        {
            btnConnect.Enabled = !isConnected;
            btnDisconnect.Enabled = isConnected;
            txtIPAddress.Enabled = !isConnected;

            grpLiveView.Enabled = isConnected;
            btnStartLiveView.Enabled = isConnected && !isLive;
            btnStopLiveView.Enabled = isConnected && isLive;
            btnManualGrab.Enabled = isConnected;

            grpMainStatus.Enabled = isConnected;
            btnStartCycle.Enabled = isConnected && !isCycling;
            btnStopCycle.Enabled = isConnected && isCycling;

            grpScheduleTime.Enabled = !isCycling;
        }

        #endregion
    }
}