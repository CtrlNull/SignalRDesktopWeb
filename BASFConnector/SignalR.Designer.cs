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
            this.label2 = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.txtSignalRMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSignalRError = new System.Windows.Forms.TextBox();
            this.txtSignalR = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaxAmount = new System.Windows.Forms.Label();
            this.txtLiveCOM = new System.Windows.Forms.TextBox();
            this.txtLiveScale = new System.Windows.Forms.TextBox();
            this.btnServerTesting = new System.Windows.Forms.Button();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboUser);
            this.groupBox2.Controls.Add(this.txtSignalRMessage);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtSignalRError);
            this.groupBox2.Controls.Add(this.txtSignalR);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(15, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 134);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SignalR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter a Message";
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Chat",
            "Mettler Toledo"});
            this.cboUser.Location = new System.Drawing.Point(18, 50);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(64, 21);
            this.cboUser.TabIndex = 5;
            // 
            // txtSignalRMessage
            // 
            this.txtSignalRMessage.Location = new System.Drawing.Point(18, 101);
            this.txtSignalRMessage.Multiline = true;
            this.txtSignalRMessage.Name = "txtSignalRMessage";
            this.txtSignalRMessage.Size = new System.Drawing.Size(142, 19);
            this.txtSignalRMessage.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSignalRError
            // 
            this.txtSignalRError.Location = new System.Drawing.Point(125, 16);
            this.txtSignalRError.Multiline = true;
            this.txtSignalRError.Name = "txtSignalRError";
            this.txtSignalRError.Size = new System.Drawing.Size(172, 23);
            this.txtSignalRError.TabIndex = 2;
            // 
            // txtSignalR
            // 
            this.txtSignalR.Location = new System.Drawing.Point(166, 50);
            this.txtSignalR.Multiline = true;
            this.txtSignalR.Name = "txtSignalR";
            this.txtSignalR.Size = new System.Drawing.Size(131, 70);
            this.txtSignalR.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(39, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxAmount);
            this.groupBox1.Controls.Add(this.txtLiveCOM);
            this.groupBox1.Controls.Add(this.txtLiveScale);
            this.groupBox1.Controls.Add(this.btnServerTesting);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 110);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scale Live Data";
            // 
            // lblMaxAmount
            // 
            this.lblMaxAmount.AutoSize = true;
            this.lblMaxAmount.ForeColor = System.Drawing.Color.Red;
            this.lblMaxAmount.Location = new System.Drawing.Point(60, 82);
            this.lblMaxAmount.Name = "lblMaxAmount";
            this.lblMaxAmount.Size = new System.Drawing.Size(0, 13);
            this.lblMaxAmount.TabIndex = 3;
            // 
            // txtLiveCOM
            // 
            this.txtLiveCOM.Location = new System.Drawing.Point(93, 19);
            this.txtLiveCOM.Name = "txtLiveCOM";
            this.txtLiveCOM.Size = new System.Drawing.Size(132, 20);
            this.txtLiveCOM.TabIndex = 2;
            // 
            // txtLiveScale
            // 
            this.txtLiveScale.Location = new System.Drawing.Point(150, 58);
            this.txtLiveScale.Multiline = true;
            this.txtLiveScale.Name = "txtLiveScale";
            this.txtLiveScale.Size = new System.Drawing.Size(109, 20);
            this.txtLiveScale.TabIndex = 1;
            // 
            // btnServerTesting
            // 
            this.btnServerTesting.Location = new System.Drawing.Point(61, 56);
            this.btnServerTesting.Name = "btnServerTesting";
            this.btnServerTesting.Size = new System.Drawing.Size(83, 23);
            this.btnServerTesting.TabIndex = 0;
            this.btnServerTesting.Text = "Scale Output";
            this.btnServerTesting.UseVisualStyleBackColor = true;
            this.btnServerTesting.Click += new System.EventHandler(this.btnServerTesting_Click_1);
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Location = new System.Drawing.Point(175, 123);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 13);
            this.lblError2.TabIndex = 18;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(136, 123);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 17;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
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
            // SignalR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.TextBox txtSignalRMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSignalRError;
        private System.Windows.Forms.TextBox txtSignalR;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxAmount;
        private System.Windows.Forms.TextBox txtLiveCOM;
        private System.Windows.Forms.TextBox txtLiveScale;
        private System.Windows.Forms.Button btnServerTesting;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblError;
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
    }
}