namespace label_detector
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblCameraIP = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.picMainResult = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpCameraConnection = new System.Windows.Forms.GroupBox();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.grpLiveView = new System.Windows.Forms.GroupBox();
            this.btnManualGrab = new System.Windows.Forms.Button();
            this.btnStopLiveView = new System.Windows.Forms.Button();
            this.btnStartLiveView = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnSelectSaveFolder = new System.Windows.Forms.Button();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.lblSavedFiles = new System.Windows.Forms.GroupBox();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.grpMainStatus = new System.Windows.Forms.GroupBox();
            this.btnStopCycle = new System.Windows.Forms.Button();
            this.btnStartCycle = new System.Windows.Forms.Button();
            this.grpImageFlip = new System.Windows.Forms.GroupBox();
            this.chkFlipHorizontal = new System.Windows.Forms.CheckBox();
            this.chkFlipVertical = new System.Windows.Forms.CheckBox();
            this.grpScheduleTime = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBreakTimeLabel = new System.Windows.Forms.Label();
            this.lblIntervalMilsec = new System.Windows.Forms.Label();
            this.lblIntervalSec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.lblFPS = new System.Windows.Forms.Label();
            this.lblExposure = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNextCapture = new System.Windows.Forms.Label();
            this.listSavedFiles = new System.Windows.Forms.ListBox();
            this.listSchedule = new System.Windows.Forms.ListBox();
            this.numIntervalSec = new System.Windows.Forms.NumericUpDown();
            this.numIntervalMilsec = new System.Windows.Forms.NumericUpDown();
            this.numBreakStartHH = new System.Windows.Forms.NumericUpDown();
            this.numBreakStartMM = new System.Windows.Forms.NumericUpDown();
            this.numBreakEndMM = new System.Windows.Forms.NumericUpDown();
            this.numBreakEndHH = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picMainResult)).BeginInit();
            this.grpCameraConnection.SuspendLayout();
            this.grpLiveView.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.lblSavedFiles.SuspendLayout();
            this.grpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.grpMainStatus.SuspendLayout();
            this.grpImageFlip.SuspendLayout();
            this.grpScheduleTime.SuspendLayout();
            this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalMilsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakStartHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakStartMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakEndMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakEndHH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(158, 41);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 23);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // lblCameraIP
            // 
            this.lblCameraIP.AutoSize = true;
            this.lblCameraIP.Location = new System.Drawing.Point(6, 17);
            this.lblCameraIP.Name = "lblCameraIP";
            this.lblCameraIP.Size = new System.Drawing.Size(67, 12);
            this.lblCameraIP.TabIndex = 1;
            this.lblCameraIP.Text = "IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(79, 14);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(169, 21);
            this.txtIPAddress.TabIndex = 2;
            // 
            // picMainResult
            // 
            this.picMainResult.Location = new System.Drawing.Point(174, 158);
            this.picMainResult.Name = "picMainResult";
            this.picMainResult.Size = new System.Drawing.Size(415, 265);
            this.picMainResult.TabIndex = 3;
            this.picMainResult.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(79, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // grpCameraConnection
            // 
            this.grpCameraConnection.Controls.Add(this.lblStatusLabel);
            this.grpCameraConnection.Controls.Add(this.lblCameraIP);
            this.grpCameraConnection.Controls.Add(this.txtIPAddress);
            this.grpCameraConnection.Controls.Add(this.btnConnect);
            this.grpCameraConnection.Controls.Add(this.btnDisconnect);
            this.grpCameraConnection.Location = new System.Drawing.Point(274, 9);
            this.grpCameraConnection.Name = "grpCameraConnection";
            this.grpCameraConnection.Size = new System.Drawing.Size(254, 87);
            this.grpCameraConnection.TabIndex = 9;
            this.grpCameraConnection.TabStop = false;
            this.grpCameraConnection.Text = "카메라 연결";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(6, 69);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(44, 12);
            this.lblStatusLabel.TabIndex = 9;
            this.lblStatusLabel.Text = "Status:";
            // 
            // grpLiveView
            // 
            this.grpLiveView.Controls.Add(this.btnManualGrab);
            this.grpLiveView.Controls.Add(this.btnStopLiveView);
            this.grpLiveView.Controls.Add(this.btnStartLiveView);
            this.grpLiveView.Location = new System.Drawing.Point(534, 9);
            this.grpLiveView.Name = "grpLiveView";
            this.grpLiveView.Size = new System.Drawing.Size(245, 87);
            this.grpLiveView.TabIndex = 10;
            this.grpLiveView.TabStop = false;
            this.grpLiveView.Text = "Live View Control";
            // 
            // btnManualGrab
            // 
            this.btnManualGrab.Location = new System.Drawing.Point(6, 46);
            this.btnManualGrab.Name = "btnManualGrab";
            this.btnManualGrab.Size = new System.Drawing.Size(233, 35);
            this.btnManualGrab.TabIndex = 12;
            this.btnManualGrab.Text = "Manual Grab [바로 저장]";
            this.btnManualGrab.UseVisualStyleBackColor = true;
            // 
            // btnStopLiveView
            // 
            this.btnStopLiveView.Location = new System.Drawing.Point(122, 17);
            this.btnStopLiveView.Name = "btnStopLiveView";
            this.btnStopLiveView.Size = new System.Drawing.Size(117, 23);
            this.btnStopLiveView.TabIndex = 11;
            this.btnStopLiveView.Text = "Stop Live View";
            this.btnStopLiveView.UseVisualStyleBackColor = true;
            // 
            // btnStartLiveView
            // 
            this.btnStartLiveView.Location = new System.Drawing.Point(6, 17);
            this.btnStartLiveView.Name = "btnStartLiveView";
            this.btnStartLiveView.Size = new System.Drawing.Size(110, 23);
            this.btnStartLiveView.TabIndex = 10;
            this.btnStartLiveView.Text = "Start Live View";
            this.btnStartLiveView.UseVisualStyleBackColor = true;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.btnSelectSaveFolder);
            this.grpOutput.Controls.Add(this.txtSaveFolder);
            this.grpOutput.Controls.Add(this.label4);
            this.grpOutput.Controls.Add(this.lblSaveFolder);
            this.grpOutput.Location = new System.Drawing.Point(12, 96);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(445, 56);
            this.grpOutput.TabIndex = 13;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "OUTPUT";
            // 
            // btnSelectSaveFolder
            // 
            this.btnSelectSaveFolder.Location = new System.Drawing.Point(360, 18);
            this.btnSelectSaveFolder.Name = "btnSelectSaveFolder";
            this.btnSelectSaveFolder.Size = new System.Drawing.Size(79, 23);
            this.btnSelectSaveFolder.TabIndex = 10;
            this.btnSelectSaveFolder.Text = "Browse";
            this.btnSelectSaveFolder.UseVisualStyleBackColor = true;
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Location = new System.Drawing.Point(84, 20);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(270, 21);
            this.txtSaveFolder.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last save: mm/ss";
            // 
            // lblSaveFolder
            // 
            this.lblSaveFolder.AutoSize = true;
            this.lblSaveFolder.Location = new System.Drawing.Point(6, 23);
            this.lblSaveFolder.Name = "lblSaveFolder";
            this.lblSaveFolder.Size = new System.Drawing.Size(72, 12);
            this.lblSaveFolder.TabIndex = 10;
            this.lblSaveFolder.Text = "Save Folder";
            // 
            // lblSavedFiles
            // 
            this.lblSavedFiles.Controls.Add(this.listSavedFiles);
            this.lblSavedFiles.Location = new System.Drawing.Point(12, 158);
            this.lblSavedFiles.Name = "lblSavedFiles";
            this.lblSavedFiles.Size = new System.Drawing.Size(156, 250);
            this.lblSavedFiles.TabIndex = 14;
            this.lblSavedFiles.TabStop = false;
            this.lblSavedFiles.Text = "Saved Files";
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.picPreview);
            this.grpPreview.Location = new System.Drawing.Point(12, 414);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(156, 129);
            this.grpPreview.TabIndex = 15;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(6, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(144, 111);
            this.picPreview.TabIndex = 16;
            this.picPreview.TabStop = false;
            // 
            // grpMainStatus
            // 
            this.grpMainStatus.Controls.Add(this.lblNextCapture);
            this.grpMainStatus.Controls.Add(this.lblStatus);
            this.grpMainStatus.Controls.Add(this.btnStopCycle);
            this.grpMainStatus.Controls.Add(this.btnStartCycle);
            this.grpMainStatus.Location = new System.Drawing.Point(463, 96);
            this.grpMainStatus.Name = "grpMainStatus";
            this.grpMainStatus.Size = new System.Drawing.Size(441, 56);
            this.grpMainStatus.TabIndex = 14;
            this.grpMainStatus.TabStop = false;
            this.grpMainStatus.Text = "MAIN STATUS";
            // 
            // btnStopCycle
            // 
            this.btnStopCycle.Location = new System.Drawing.Point(130, 18);
            this.btnStopCycle.Name = "btnStopCycle";
            this.btnStopCycle.Size = new System.Drawing.Size(120, 23);
            this.btnStopCycle.TabIndex = 12;
            this.btnStopCycle.Text = "STOP CYCLE";
            this.btnStopCycle.UseVisualStyleBackColor = true;
            // 
            // btnStartCycle
            // 
            this.btnStartCycle.Location = new System.Drawing.Point(6, 18);
            this.btnStartCycle.Name = "btnStartCycle";
            this.btnStartCycle.Size = new System.Drawing.Size(120, 23);
            this.btnStartCycle.TabIndex = 11;
            this.btnStartCycle.Text = "START CYCLE";
            this.btnStartCycle.UseVisualStyleBackColor = true;
            // 
            // grpImageFlip
            // 
            this.grpImageFlip.Controls.Add(this.chkFlipHorizontal);
            this.grpImageFlip.Controls.Add(this.chkFlipVertical);
            this.grpImageFlip.Location = new System.Drawing.Point(783, 9);
            this.grpImageFlip.Name = "grpImageFlip";
            this.grpImageFlip.Size = new System.Drawing.Size(121, 87);
            this.grpImageFlip.TabIndex = 15;
            this.grpImageFlip.TabStop = false;
            this.grpImageFlip.Text = "IMAGE FLIP";
            // 
            // chkFlipHorizontal
            // 
            this.chkFlipHorizontal.AutoSize = true;
            this.chkFlipHorizontal.Location = new System.Drawing.Point(6, 39);
            this.chkFlipHorizontal.Name = "chkFlipHorizontal";
            this.chkFlipHorizontal.Size = new System.Drawing.Size(104, 16);
            this.chkFlipHorizontal.TabIndex = 1;
            this.chkFlipHorizontal.Text = "Flip Horizontal";
            this.chkFlipHorizontal.UseVisualStyleBackColor = true;
            // 
            // chkFlipVertical
            // 
            this.chkFlipVertical.AutoSize = true;
            this.chkFlipVertical.Location = new System.Drawing.Point(6, 17);
            this.chkFlipVertical.Name = "chkFlipVertical";
            this.chkFlipVertical.Size = new System.Drawing.Size(90, 16);
            this.chkFlipVertical.TabIndex = 0;
            this.chkFlipVertical.Text = "Flip Vertical";
            this.chkFlipVertical.UseVisualStyleBackColor = true;
            // 
            // grpScheduleTime
            // 
            this.grpScheduleTime.Controls.Add(this.numBreakEndMM);
            this.grpScheduleTime.Controls.Add(this.numBreakEndHH);
            this.grpScheduleTime.Controls.Add(this.numBreakStartMM);
            this.grpScheduleTime.Controls.Add(this.numBreakStartHH);
            this.grpScheduleTime.Controls.Add(this.numIntervalMilsec);
            this.grpScheduleTime.Controls.Add(this.numIntervalSec);
            this.grpScheduleTime.Controls.Add(this.listSchedule);
            this.grpScheduleTime.Controls.Add(this.btnRemoveSchedule);
            this.grpScheduleTime.Controls.Add(this.btnAddSchedule);
            this.grpScheduleTime.Controls.Add(this.label6);
            this.grpScheduleTime.Controls.Add(this.label7);
            this.grpScheduleTime.Controls.Add(this.label5);
            this.grpScheduleTime.Controls.Add(this.label2);
            this.grpScheduleTime.Controls.Add(this.label8);
            this.grpScheduleTime.Controls.Add(this.lblBreakTimeLabel);
            this.grpScheduleTime.Controls.Add(this.lblIntervalMilsec);
            this.grpScheduleTime.Controls.Add(this.lblIntervalSec);
            this.grpScheduleTime.Location = new System.Drawing.Point(713, 158);
            this.grpScheduleTime.Name = "grpScheduleTime";
            this.grpScheduleTime.Size = new System.Drawing.Size(191, 385);
            this.grpScheduleTime.TabIndex = 17;
            this.grpScheduleTime.TabStop = false;
            this.grpScheduleTime.Text = "Schedule Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Break-time To";
            // 
            // lblBreakTimeLabel
            // 
            this.lblBreakTimeLabel.AutoSize = true;
            this.lblBreakTimeLabel.Location = new System.Drawing.Point(5, 103);
            this.lblBreakTimeLabel.Name = "lblBreakTimeLabel";
            this.lblBreakTimeLabel.Size = new System.Drawing.Size(100, 12);
            this.lblBreakTimeLabel.TabIndex = 10;
            this.lblBreakTimeLabel.Text = "Break-time From";
            // 
            // lblIntervalMilsec
            // 
            this.lblIntervalMilsec.AutoSize = true;
            this.lblIntervalMilsec.Location = new System.Drawing.Point(4, 59);
            this.lblIntervalMilsec.Name = "lblIntervalMilsec";
            this.lblIntervalMilsec.Size = new System.Drawing.Size(123, 12);
            this.lblIntervalMilsec.TabIndex = 12;
            this.lblIntervalMilsec.Text = "Milisecond [Interval]";
            // 
            // lblIntervalSec
            // 
            this.lblIntervalSec.AutoSize = true;
            this.lblIntervalSec.Location = new System.Drawing.Point(4, 20);
            this.lblIntervalSec.Name = "lblIntervalSec";
            this.lblIntervalSec.Size = new System.Drawing.Size(104, 12);
            this.lblIntervalSec.TabIndex = 11;
            this.lblIntervalSec.Text = "Second [Interval]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "HH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "MM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "MM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "HH";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(7, 187);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(84, 23);
            this.btnAddSchedule.TabIndex = 10;
            this.btnAddSchedule.Text = "Add";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Location = new System.Drawing.Point(96, 187);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveSchedule.TabIndex = 23;
            this.btnRemoveSchedule.Text = "Remove";
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(174, 426);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(48, 12);
            this.lblFPS.TabIndex = 10;
            this.lblFPS.Text = "FPS: 00";
            // 
            // lblExposure
            // 
            this.lblExposure.AutoSize = true;
            this.lblExposure.Location = new System.Drawing.Point(174, 438);
            this.lblExposure.Name = "lblExposure";
            this.lblExposure.Size = new System.Drawing.Size(97, 12);
            this.lblExposure.TabIndex = 18;
            this.lblExposure.Text = "Exposure: 00 µs";
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(174, 450);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(64, 12);
            this.lblGain.TabIndex = 19;
            this.lblGain.Text = "Gain: 0 dB";
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Location = new System.Drawing.Point(176, 465);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(531, 78);
            this.grpLog.TabIndex = 10;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "LOG";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 14);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(519, 58);
            this.txtLog.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(252, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 12);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "CURRENT STATUS:";
            // 
            // lblNextCapture
            // 
            this.lblNextCapture.AutoSize = true;
            this.lblNextCapture.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNextCapture.Location = new System.Drawing.Point(254, 41);
            this.lblNextCapture.Name = "lblNextCapture";
            this.lblNextCapture.Size = new System.Drawing.Size(136, 11);
            this.lblNextCapture.TabIndex = 21;
            this.lblNextCapture.Text = "NEXT CAPTURE: mm/ss";
            // 
            // listSavedFiles
            // 
            this.listSavedFiles.FormattingEnabled = true;
            this.listSavedFiles.ItemHeight = 12;
            this.listSavedFiles.Location = new System.Drawing.Point(6, 12);
            this.listSavedFiles.Name = "listSavedFiles";
            this.listSavedFiles.Size = new System.Drawing.Size(144, 232);
            this.listSavedFiles.TabIndex = 20;
            // 
            // listSchedule
            // 
            this.listSchedule.FormattingEnabled = true;
            this.listSchedule.ItemHeight = 12;
            this.listSchedule.Location = new System.Drawing.Point(6, 216);
            this.listSchedule.Name = "listSchedule";
            this.listSchedule.Size = new System.Drawing.Size(179, 160);
            this.listSchedule.TabIndex = 21;
            // 
            // numIntervalSec
            // 
            this.numIntervalSec.Location = new System.Drawing.Point(7, 35);
            this.numIntervalSec.Name = "numIntervalSec";
            this.numIntervalSec.Size = new System.Drawing.Size(178, 21);
            this.numIntervalSec.TabIndex = 20;
            // 
            // numIntervalMilsec
            // 
            this.numIntervalMilsec.Location = new System.Drawing.Point(6, 74);
            this.numIntervalMilsec.Name = "numIntervalMilsec";
            this.numIntervalMilsec.Size = new System.Drawing.Size(179, 21);
            this.numIntervalMilsec.TabIndex = 20;
            // 
            // numBreakStartHH
            // 
            this.numBreakStartHH.Location = new System.Drawing.Point(34, 118);
            this.numBreakStartHH.Name = "numBreakStartHH";
            this.numBreakStartHH.Size = new System.Drawing.Size(54, 21);
            this.numBreakStartHH.TabIndex = 24;
            // 
            // numBreakStartMM
            // 
            this.numBreakStartMM.Location = new System.Drawing.Point(131, 118);
            this.numBreakStartMM.Name = "numBreakStartMM";
            this.numBreakStartMM.Size = new System.Drawing.Size(54, 21);
            this.numBreakStartMM.TabIndex = 25;
            // 
            // numBreakEndMM
            // 
            this.numBreakEndMM.Location = new System.Drawing.Point(131, 160);
            this.numBreakEndMM.Name = "numBreakEndMM";
            this.numBreakEndMM.Size = new System.Drawing.Size(54, 21);
            this.numBreakEndMM.TabIndex = 27;
            // 
            // numBreakEndHH
            // 
            this.numBreakEndHH.Location = new System.Drawing.Point(34, 160);
            this.numBreakEndHH.Name = "numBreakEndHH";
            this.numBreakEndHH.Size = new System.Drawing.Size(54, 21);
            this.numBreakEndHH.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 555);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.lblExposure);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.grpScheduleTime);
            this.Controls.Add(this.grpImageFlip);
            this.Controls.Add(this.grpMainStatus);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.lblSavedFiles);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpLiveView);
            this.Controls.Add(this.grpCameraConnection);
            this.Controls.Add(this.picMainResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picMainResult)).EndInit();
            this.grpCameraConnection.ResumeLayout(false);
            this.grpCameraConnection.PerformLayout();
            this.grpLiveView.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.lblSavedFiles.ResumeLayout(false);
            this.grpPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.grpMainStatus.ResumeLayout(false);
            this.grpMainStatus.PerformLayout();
            this.grpImageFlip.ResumeLayout(false);
            this.grpImageFlip.PerformLayout();
            this.grpScheduleTime.ResumeLayout(false);
            this.grpScheduleTime.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalMilsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakStartHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakStartMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakEndMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakEndHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblCameraIP;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.PictureBox picMainResult;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpCameraConnection;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.GroupBox grpLiveView;
        private System.Windows.Forms.Button btnManualGrab;
        private System.Windows.Forms.Button btnStopLiveView;
        private System.Windows.Forms.Button btnStartLiveView;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.Label lblSaveFolder;
        private System.Windows.Forms.GroupBox lblSavedFiles;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnSelectSaveFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpMainStatus;
        private System.Windows.Forms.Button btnStopCycle;
        private System.Windows.Forms.Button btnStartCycle;
        private System.Windows.Forms.GroupBox grpImageFlip;
        private System.Windows.Forms.CheckBox chkFlipHorizontal;
        private System.Windows.Forms.CheckBox chkFlipVertical;
        private System.Windows.Forms.GroupBox grpScheduleTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBreakTimeLabel;
        private System.Windows.Forms.Label lblIntervalMilsec;
        private System.Windows.Forms.Label lblIntervalSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblExposure;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.Label lblNextCapture;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ListBox listSavedFiles;
        private System.Windows.Forms.ListBox listSchedule;
        private System.Windows.Forms.NumericUpDown numIntervalSec;
        private System.Windows.Forms.NumericUpDown numBreakEndMM;
        private System.Windows.Forms.NumericUpDown numBreakEndHH;
        private System.Windows.Forms.NumericUpDown numBreakStartMM;
        private System.Windows.Forms.NumericUpDown numBreakStartHH;
        private System.Windows.Forms.NumericUpDown numIntervalMilsec;
    }
}

