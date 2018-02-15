using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using Microsoft.AspNet.SignalR;

namespace BASFConnector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        /// --- Btn's --- //
        // Restart Btn //
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        // Connect to Server Btn //
        // Connects the SignalR Server(console app) to the WinForm App(this app) 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IHubProxy _hub;
            try
            {
                string url = @"http://localhost:8080/";
                var connection = new HubConnection(url);
                _hub = connection.CreateHubProxy("ConnectorHub");
                connection.Start().Wait();
                lblError2.Text = null;
                lblError.Text = "SignalR Server Connected";
                // ??? -- research and add a comment
                string line = null;
                while ((line = System.Console.ReadLine()) != null)
                {
                    _hub.Invoke("DetermineLength", line).Wait();
                    _hub.Invoke("ConnectionHub", "test");

                }
            }
            catch // Spits Error symbols on the form
            {
                lblError.Text = null;
                lblError2.ForeColor = Color.Red;
                lblError2.Text = "Connection Error";
            }
        }

        /////// { Menu List below Items } ///////
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainToolStripMenuItem.Enabled = false;
        }

        // Serial Port Menu item
        private void smsSerialPort_Click(object sender, EventArgs e)
        {
            CommPorts obj = new CommPorts();
            obj.Show();
            this.Hide();
        }
        // View Logs
        private void viewLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewLogsToolStripMenuItem.Enabled = false;
        }
        // Send Logs
        private void sendLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendLogsToolStripMenuItem.Enabled = false;
        }
        // Contact us
        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactUsToolStripMenuItem.Enabled = false;
        }
    }
}
