namespace BASFConnector
{
    partial class SignalR
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblScaleWeight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtScaleErrors = new System.Windows.Forms.TextBox();
            this.txtLiveCOM = new System.Windows.Forms.TextBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.txtSignalRStatus = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smsSerialPort = new System.Windows.Forms.ToolStripMenuItem();
            this.signalRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnectScale = new System.Windows.Forms.Button();
            this.btnConnectSignalR = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnectSignalR);
            this.groupBox2.Controls.Add(this.btnConnectScale);
            this.groupBox2.Controls.Add(this.lblScaleWeight);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtLiveCOM);
            this.groupBox2.Controls.Add(this.cboUser);
            this.groupBox2.Controls.Add(this.txtSignalRStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 206);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SignalR";
            // 
            // lblScaleWeight
            // 
            this.lblScaleWeight.AutoSize = true;
            this.lblScaleWeight.Location = new System.Drawing.Point(97, 101);
            this.lblScaleWeight.Name = "lblScaleWeight";
            this.lblScaleWeight.Size = new System.Drawing.Size(0, 13);
            this.lblScaleWeight.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScaleErrors);
            this.groupBox1.Location = new System.Drawing.Point(153, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error List";
            // 
            // txtScaleErrors
            // 
            this.txtScaleErrors.Location = new System.Drawing.Point(6, 20);
            this.txtScaleErrors.Multiline = true;
            this.txtScaleErrors.Name = "txtScaleErrors";
            this.txtScaleErrors.Size = new System.Drawing.Size(93, 133);
            this.txtScaleErrors.TabIndex = 0;
            // 
            // txtLiveCOM
            // 
            this.txtLiveCOM.Location = new System.Drawing.Point(6, 22);
            this.txtLiveCOM.Name = "txtLiveCOM";
            this.txtLiveCOM.Size = new System.Drawing.Size(141, 20);
            this.txtLiveCOM.TabIndex = 2;
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Chat",
            "Mettler Toledo"});
            this.cboUser.Location = new System.Drawing.Point(83, 73);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(64, 21);
            this.cboUser.TabIndex = 5;
            // 
            // txtSignalRStatus
            // 
            this.txtSignalRStatus.Location = new System.Drawing.Point(6, 48);
            this.txtSignalRStatus.Multiline = true;
            this.txtSignalRStatus.Name = "txtSignalRStatus";
            this.txtSignalRStatus.Size = new System.Drawing.Size(141, 20);
            this.txtSignalRStatus.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smsSerialPort,
            this.signalRToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // smsSerialPort
            // 
            this.smsSerialPort.Name = "smsSerialPort";
            this.smsSerialPort.Size = new System.Drawing.Size(130, 22);
            this.smsSerialPort.Text = "Serial Port ";
            this.smsSerialPort.Click += new System.EventHandler(this.smsSerialPort_Click);
            // 
            // signalRToolStripMenuItem
            // 
            this.signalRToolStripMenuItem.Name = "signalRToolStripMenuItem";
            this.signalRToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.signalRToolStripMenuItem.Text = "SignalR";
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
            // btnConnectScale
            // 
            this.btnConnectScale.Location = new System.Drawing.Point(6, 74);
            this.btnConnectScale.Name = "btnConnectScale";
            this.btnConnectScale.Size = new System.Drawing.Size(71, 20);
            this.btnConnectScale.TabIndex = 8;
            this.btnConnectScale.Text = "Scale Data";
            this.btnConnectScale.UseVisualStyleBackColor = true;
            this.btnConnectScale.Click += new System.EventHandler(this.btnConnectScale_Click);
            // 
            // btnConnectSignalR
            // 
            this.btnConnectSignalR.Location = new System.Drawing.Point(7, 101);
            this.btnConnectSignalR.Name = "btnConnectSignalR";
            this.btnConnectSignalR.Size = new System.Drawing.Size(70, 22);
            this.btnConnectSignalR.TabIndex = 9;
            this.btnConnectSignalR.Text = "SignalR";
            this.btnConnectSignalR.UseVisualStyleBackColor = true;
            this.btnConnectSignalR.Click += new System.EventHandler(this.btnConnectSignalR_Click);
            // 
            // SignalR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 238);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SignalR";
            this.Text = "SignalR - Alpha v.1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.TextBox txtSignalRStatus;
        private System.Windows.Forms.TextBox txtLiveCOM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smsSerialPort;
        private System.Windows.Forms.ToolStripMenuItem signalRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtScaleErrors;
        private System.Windows.Forms.Label lblScaleWeight;
        private System.Windows.Forms.Button btnConnectScale;
        private System.Windows.Forms.Button btnConnectSignalR;
    }
}