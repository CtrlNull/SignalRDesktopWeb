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

        // Server Start Btn //
        // Starts Console application for SignalR Server ***Change for production***
        private void btnServerStart_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\rapha\\repos\\Builds\\BASFConnectorConsole\\BASFConnectorConsole.exe");
        }
        
        // Connect to Server Btn //
        // Connects the SignalR Server(console app) to the WinForm App(this app) 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                IHubProxy _hub;
                string url = @"http://localhost:8080/";
                var connection = new HubConnection(url);
                _hub = connection.CreateHubProxy("TestHub");
                //connection.Start().Wait();
            }
            catch
            {
                Console.WriteLine("Error");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
