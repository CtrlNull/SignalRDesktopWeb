namespace BASFConnector
{
    partial class CommPorts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboPorts_Comm = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckDevice = new System.Windows.Forms.Button();
            this.pbDevice = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCOMM = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSignalRMessage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSignalRReturn = new System.Windows.Forms.TextBox();
            this.txtSignalRMessage = new System.Windows.Forms.TextBox();
            this.btnSignalRConnect = new System.Windows.Forms.Button();
            this.pbarSignalR = new System.Windows.Forms.ProgressBar();
            this.rdoScale = new System.Windows.Forms.RadioButton();
            this.rdoMessages = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTestingOutput = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnTesting = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtWeightLimit = new System.Windows.Forms.TextBox();
            this.btnRecieve = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRecieve = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPorts_Comm
            // 
            this.cboPorts_Comm.FormattingEnabled = true;
            this.cboPorts_Comm.Location = new System.Drawing.Point(6, 22);
            this.cboPorts_Comm.Name = "cboPorts_Comm";
            this.cboPorts_Comm.Size = new System.Drawing.Size(75, 21);
            this.cboPorts_Comm.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.testScaleToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // testScaleToolStripMenuItem
            // 
            this.testScaleToolStripMenuItem.Name = "testScaleToolStripMenuItem";
            this.testScaleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.testScaleToolStripMenuItem.Text = "Test Scale";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortToolStripMenuItem,
            this.signalRToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serialPortToolStripMenuItem.Text = "Serial Port";
            // 
            // signalRToolStripMenuItem
            // 
            this.signalRToolStripMenuItem.Name = "signalRToolStripMenuItem";
            this.signalRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.signalRToolStripMenuItem.Text = "SignalR";
            this.signalRToolStripMenuItem.Click += new System.EventHandler(this.signalRToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogsToolStripMenuItem,
            this.sendLogsToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewLogsToolStripMenuItem
            // 
            this.viewLogsToolStripMenuItem.Name = "viewLogsToolStripMenuItem";
            this.viewLogsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.viewLogsToolStripMenuItem.Text = "View Logs";
            // 
            // sendLogsToolStripMenuItem
            // 
            this.sendLogsToolStripMenuItem.Name = "sendLogsToolStripMenuItem";
            this.sendLogsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sendLogsToolStripMenuItem.Text = "Send Logs";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            // 
            // btnCheckDevice
            // 
            this.btnCheckDevice.Location = new System.Drawing.Point(106, 19);
            this.btnCheckDevice.Name = "btnCheckDevice";
            this.btnCheckDevice.Size = new System.Drawing.Size(53, 24);
            this.btnCheckDevice.TabIndex = 10;
            this.btnCheckDevice.Text = "Check";
            this.btnCheckDevice.UseVisualStyleBackColor = true;
            this.btnCheckDevice.Click += new System.EventHandler(this.btnCheckDevice_Click);
            // 
            // pbDevice
            // 
            this.pbDevice.Location = new System.Drawing.Point(55, 28);
            this.pbDevice.Name = "pbDevice";
            this.pbDevice.Size = new System.Drawing.Size(10, 10);
            this.pbDevice.TabIndex = 13;
            this.pbDevice.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(106, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(53, 24);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClosePort);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.statusBar);
            this.groupBox1.Controls.Add(this.btnCheckDevice);
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.cboPorts_Comm);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 128);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Testing Area";
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(6, 94);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(75, 23);
            this.btnClosePort.TabIndex = 5;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(6, 78);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(75, 10);
            this.statusBar.TabIndex = 18;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(6, 49);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 4;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Device Name:";
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Location = new System.Drawing.Point(81, 24);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(0, 13);
            this.lblDeviceStatus.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCOMM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblDeviceStatus);
            this.groupBox2.Controls.Add(this.pbDevice);
            this.groupBox2.Location = new System.Drawing.Point(188, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 127);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Port Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Port: ";
            // 
            // lblCOMM
            // 
            this.lblCOMM.AutoSize = true;
            this.lblCOMM.Location = new System.Drawing.Point(90, 57);
            this.lblCOMM.Name = "lblCOMM";
            this.lblCOMM.Size = new System.Drawing.Size(0, 13);
            this.lblCOMM.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSignalRMessage);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSignalRReturn);
            this.groupBox3.Controls.Add(this.txtSignalRMessage);
            this.groupBox3.Controls.Add(this.btnSignalRConnect);
            this.groupBox3.Controls.Add(this.pbarSignalR);
            this.groupBox3.Controls.Add(this.rdoScale);
            this.groupBox3.Controls.Add(this.rdoMessages);
            this.groupBox3.Location = new System.Drawing.Point(13, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 112);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SignalR Testing Area";
            // 
            // btnSignalRMessage
            // 
            this.btnSignalRMessage.Location = new System.Drawing.Point(173, 34);
            this.btnSignalRMessage.Name = "btnSignalRMessage";
            this.btnSignalRMessage.Size = new System.Drawing.Size(86, 23);
            this.btnSignalRMessage.TabIndex = 8;
            this.btnSignalRMessage.Text = "Send Message";
            this.btnSignalRMessage.UseVisualStyleBackColor = true;
            this.btnSignalRMessage.Click += new System.EventHandler(this.btnSignalRMessage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "SignalR Hub";
            // 
            // txtSignalRReturn
            // 
            this.txtSignalRReturn.Location = new System.Drawing.Point(330, 32);
            this.txtSignalRReturn.Multiline = true;
            this.txtSignalRReturn.Name = "txtSignalRReturn";
            this.txtSignalRReturn.Size = new System.Drawing.Size(100, 70);
            this.txtSignalRReturn.TabIndex = 1;
            // 
            // txtSignalRMessage
            // 
            this.txtSignalRMessage.Location = new System.Drawing.Point(140, 63);
            this.txtSignalRMessage.Name = "txtSignalRMessage";
            this.txtSignalRMessage.Size = new System.Drawing.Size(149, 20);
            this.txtSignalRMessage.TabIndex = 4;
            // 
            // btnSignalRConnect
            // 
            this.btnSignalRConnect.Location = new System.Drawing.Point(15, 67);
            this.btnSignalRConnect.Name = "btnSignalRConnect";
            this.btnSignalRConnect.Size = new System.Drawing.Size(75, 23);
            this.btnSignalRConnect.TabIndex = 3;
            this.btnSignalRConnect.Text = "Connect";
            this.btnSignalRConnect.UseVisualStyleBackColor = true;
            this.btnSignalRConnect.Click += new System.EventHandler(this.btnSignalRConnect_Click);
            // 
            // pbarSignalR
            // 
            this.pbarSignalR.Location = new System.Drawing.Point(140, 0);
            this.pbarSignalR.Name = "pbarSignalR";
            this.pbarSignalR.Size = new System.Drawing.Size(155, 10);
            this.pbarSignalR.TabIndex = 2;
            // 
            // rdoScale
            // 
            this.rdoScale.AutoSize = true;
            this.rdoScale.Location = new System.Drawing.Point(17, 44);
            this.rdoScale.Name = "rdoScale";
            this.rdoScale.Size = new System.Drawing.Size(104, 17);
            this.rdoScale.TabIndex = 1;
            this.rdoScale.TabStop = true;
            this.rdoScale.Text = "Scale to SignalR";
            this.rdoScale.UseVisualStyleBackColor = true;
            // 
            // rdoMessages
            // 
            this.rdoMessages.AutoSize = true;
            this.rdoMessages.Location = new System.Drawing.Point(17, 20);
            this.rdoMessages.Name = "rdoMessages";
            this.rdoMessages.Size = new System.Drawing.Size(73, 17);
            this.rdoMessages.TabIndex = 0;
            this.rdoMessages.TabStop = true;
            this.rdoMessages.Text = "Messages";
            this.rdoMessages.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtOutput);
            this.groupBox5.Controls.Add(this.txtWeightLimit);
            this.groupBox5.Controls.Add(this.btnRecieve);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cboRecieve);
            this.groupBox5.Location = new System.Drawing.Point(12, 161);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(447, 148);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Scale Testing Area";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTestingOutput);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.btnTesting);
            this.groupBox4.Location = new System.Drawing.Point(212, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 117);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Testing Area";
            // 
            // txtTestingOutput
            // 
            this.txtTestingOutput.Location = new System.Drawing.Point(136, 53);
            this.txtTestingOutput.Multiline = true;
            this.txtTestingOutput.Name = "txtTestingOutput";
            this.txtTestingOutput.Size = new System.Drawing.Size(39, 20);
            this.txtTestingOutput.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 20);
            this.progressBar1.TabIndex = 11;
            // 
            // btnTesting
            // 
            this.btnTesting.Location = new System.Drawing.Point(144, 10);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(75, 23);
            this.btnTesting.TabIndex = 10;
            this.btnTesting.Text = "btnTesting";
            this.btnTesting.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(26, 111);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(77, 25);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.WordWrap = false;
            // 
            // txtWeightLimit
            // 
            this.txtWeightLimit.Location = new System.Drawing.Point(29, 72);
            this.txtWeightLimit.Name = "txtWeightLimit";
            this.txtWeightLimit.Size = new System.Drawing.Size(65, 20);
            this.txtWeightLimit.TabIndex = 8;
            // 
            // btnRecieve
            // 
            this.btnRecieve.Location = new System.Drawing.Point(122, 28);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(75, 25);
            this.btnRecieve.TabIndex = 3;
            this.btnRecieve.Text = "Recieve";
            this.btnRecieve.UseVisualStyleBackColor = true;
            this.btnRecieve.Click += new System.EventHandler(this.btnRecieve_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Weight Limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Response";
            // 
            // cboRecieve
            // 
            this.cboRecieve.FormattingEnabled = true;
            this.cboRecieve.Items.AddRange(new object[] {
            "Show Weight"});
            this.cboRecieve.Location = new System.Drawing.Point(18, 32);
            this.cboRecieve.Name = "cboRecieve";
            this.cboRecieve.Size = new System.Drawing.Size(85, 21);
            this.cboRecieve.TabIndex = 2;
            // 
            // CommPorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 435);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CommPorts";
            this.Text = "CommPorts - Alpha v.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboPorts_Comm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.Button btnCheckDevice;
        private System.Windows.Forms.PictureBox pbDevice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCOMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem testScaleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnRecieve;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtOutput;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.ComboBox cboRecieve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeightLimit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTestingOutput;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSignalRMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSignalRReturn;
        private System.Windows.Forms.TextBox txtSignalRMessage;
        private System.Windows.Forms.Button btnSignalRConnect;
        private System.Windows.Forms.ProgressBar pbarSignalR;
        private System.Windows.Forms.RadioButton rdoScale;
        private System.Windows.Forms.RadioButton rdoMessages;
        private System.Windows.Forms.ToolStripMenuItem signalRToolStripMenuItem;
    }
}