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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            IHubProxy _hub;
            string url = @"http://localhost:8080/";
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("TestHub");
            connection.Start().Wait();

        }
        // Serial <Port> Btn//
        // This will initialize the check for serial ports
        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);
            }

            while (!((ArrayComPortsNames[index] == ComPortName)
                          || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            cboPorts.Text = ArrayComPortsNames[0]; // Outputs Port names on Combo list
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
