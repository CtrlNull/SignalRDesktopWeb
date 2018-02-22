using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASFConnector
{
    public partial class SignalR : Form
    {
        public SignalR()
        {
            InitializeComponent();
            viewLogsToolStripMenuItem.Enabled = false;
            sendLogsToolStripMenuItem.Enabled = false;
            contactUsToolStripMenuItem.Enabled = false;
            signalRToolStripMenuItem.Enabled = false;

            // Try/Catch to check if the device is connected
            try
            {
                openPort();
            }
            catch
            {
                txtLiveCOM.Text = "COM5 isnt Connected, Restart";
            }
        }
        ///===================== V Menu Items V ====================//
        // Serial Ports
        private void smsSerialPort_Click(object sender, EventArgs e)
        {
            CommPorts obj = new CommPorts();
            obj.Show();
            this.Hide();
        }
        // Main Menu
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            obj.Show();
            this.Hide();
        }
        ///===================== V Processes V ====================//

        // Checks and opens port
        void openPort()
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = "COM5"; // Fixed COM port *
                serialPort1.BaudRate = 9600; // Important to set
                serialPort1.Parity = Parity.None; // Important to set
                serialPort1.Open();
                txtLiveCOM.Text = "COM5 is Connected";
            }
            else
            {
                closePort();
                openPort();
                Console.WriteLine("Serial Port is already open");
            }
        }

        // Close Port
        void closePort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose();
            }
        }
        // Write to txtBox SignalR
        void writeTo(string x)
        {
            txtSignalR.Text = x;
        }
        // Run Scale data
        void scaleData()
        {
            bool portOpen = true;
            double scaleDataConverted;
            string hubDesiredAmount = "20.0";
            double desiredAmount = 100.00;

            if (hubDesiredAmount != "")
            {
                if (serialPort1.IsOpen)
                {
                    portOpen = true;
                }
                // Loop until the scale reaches user's desired amount
                while (portOpen == true)
                {
                    string scaleOutput = serialPort1.ReadLine(); // needed to read port info
                    scaleOutput = Regex.Replace(scaleOutput, @"[^-?0-9.,]", ""); // Regex to remove scale's SS
                    txtLiveScale.Text = scaleOutput;
                    scaleDataConverted = Convert.ToDouble(scaleOutput);

                    // This will check if the user's amount is reached and logs it to the screen
                    if (scaleDataConverted == desiredAmount || scaleDataConverted >= desiredAmount)
                    {
                        // Txt to tell user ammount is reached. *Change from static*
                        lblMaxAmount.Text = "Required Ammount Reached. Click Restart...";
                        txtLiveCOM.Text = "COM5 is disconnected";
                        // Close port, set var to exit loop
                        closePort();
                        portOpen = false; // Set the loop to stop
                        txtLiveScale.Text = Convert.ToString(scaleDataConverted); // Output amount used
                    }
                }
            }
            else
            {
                txtLiveCOM.Text = "There is no incoming weight";
            }
        }

        ///===================== V Buttons V ====================//

        // Scale Output //
        private void btnServerTesting_Click_1(object sender, EventArgs e)
        {
            // This is for original bug which would throw an error for scale input = ""
            if (serialPort1.ReadLine() == "")
            {
                closePort();
                openPort();
            }

            scaleData(); // Connects to scale

        }

        // Connects the SignalR Server(console app) to the WinForm App(this app) 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //var uiCtx = SynchronizationContext.Current;
            IHubProxy _hub;
            try
            {
                string url = @"http://localhost:62035/"; // Make sure this matches the clientside web browser Ip**
                var connection = new HubConnection(url);
                _hub = connection.CreateHubProxy("ConnectorHub");
                connection.Start().Wait();
                txtSignalRError.Text = null;
                txtSignalRError.Text = "SignalR Hub is Connected";
                try
                {
                    // Solves Cross threading issue
                    var uiCtx = SynchronizationContext.Current;
                    _hub.On("recieveMessage", x =>
                    {
                        // You are no longer on the UI thread, so you have to post back to it
                        uiCtx.Post(_ =>
                        {
                            // Put all code that touches the UI here
                            writeTo(x);
                        }, null);
                    });

                }
                catch
                {
                    txtSignalR.Text = "new error";
                }
                var toFront = txtSignalRMessage.Text;
            }
            catch // Spits Error symbols on the form
            {
                txtSignalRError.Text = null;
                txtSignalRError.ForeColor = Color.Red;
                txtSignalRError.Text = "Connection Error";
            }
        }

    }
}
