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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckDevice = new System.Windows.Forms.Button();
            this.pbDevice = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCOMM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRecieve = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.selectPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPorts_Comm
            // 
            this.cboPorts_Comm.FormattingEnabled = true;
            this.cboPorts_Comm.Location = new System.Drawing.Point(22, 22);
            this.cboPorts_Comm.Name = "cboPorts_Comm";
            this.cboPorts_Comm.Size = new System.Drawing.Size(59, 21);
            this.cboPorts_Comm.TabIndex = 1;
            this.cboPorts_Comm.SelectedIndexChanged += new System.EventHandler(this.cboPorts_Comm_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
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
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortToolStripMenuItem,
            this.selectPortToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serialPortToolStripMenuItem.Text = "Serial Port";
            this.serialPortToolStripMenuItem.Click += new System.EventHandler(this.serialPortToolStripMenuItem_Click);
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
            this.viewLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewLogsToolStripMenuItem.Text = "View Logs";
            // 
            // sendLogsToolStripMenuItem
            // 
            this.sendLogsToolStripMenuItem.Name = "sendLogsToolStripMenuItem";
            this.sendLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendLogsToolStripMenuItem.Text = "Send Logs";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnCheckDevice);
            this.groupBox1.Controls.Add(this.cboPorts_Comm);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 128);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Port";
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
            this.groupBox2.Text = "Status";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblCOMM
            // 
            this.lblCOMM.AutoSize = true;
            this.lblCOMM.Location = new System.Drawing.Point(90, 57);
            this.lblCOMM.Name = "lblCOMM";
            this.lblCOMM.Size = new System.Drawing.Size(0, 13);
            this.lblCOMM.TabIndex = 16;
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
            // testScaleToolStripMenuItem
            // 
            this.testScaleToolStripMenuItem.Name = "testScaleToolStripMenuItem";
            this.testScaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testScaleToolStripMenuItem.Text = "Test Scale";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClosePort);
            this.groupBox3.Controls.Add(this.btnOpenPort);
            this.groupBox3.Controls.Add(this.btnRecieve);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(14, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 284);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Testing";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtInput);
            this.groupBox4.Location = new System.Drawing.Point(10, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 191);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtOutput);
            this.groupBox5.Location = new System.Drawing.Point(242, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 219);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(82, 246);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnRecieve
            // 
            this.btnRecieve.Location = new System.Drawing.Point(304, 245);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(75, 23);
            this.btnRecieve.TabIndex = 3;
            this.btnRecieve.Text = "Recieve";
            this.btnRecieve.UseVisualStyleBackColor = true;
            this.btnRecieve.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(34, 20);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 4;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(131, 20);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(75, 23);
            this.btnClosePort.TabIndex = 5;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(10, 19);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(203, 166);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(187, 194);
            this.txtOutput.TabIndex = 1;
            // 
            // selectPortToolStripMenuItem
            // 
            this.selectPortToolStripMenuItem.Name = "selectPortToolStripMenuItem";
            this.selectPortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectPortToolStripMenuItem.Text = "Select Port";
            // 
            // CommPorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 474);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ToolStripMenuItem selectPortToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
    }
}