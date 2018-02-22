using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.AspNet.SignalR.Client;
using System.Threading;

namespace BASFConnector
{
    public partial class CommPorts : Form
    {
        private HubConnection _connection;
        private IHubProxy _hub;

        ///~~~ Main ~~~///
        public CommPorts()
        {
            InitializeComponent();

            // Button disabling
            getAvaliablePorts();
            txtOutput.Enabled = false;
            btnRecieve.Enabled = false;
            btnClosePort.Enabled = true;
            btnTesting.Enabled = false;
            serialPortToolStripMenuItem.Enabled = false;
            btnSignalRMessage.Enabled = false;
            statusBar.Value = 0;

            // SignalR initializing
            string url = @"http://localhost:62035/"; // Make sure this matches the clientside web browser Ip**
            _connection = new HubConnection(url);
            _hub = _connection.CreateHubProxy("ConnectorHub");

        }
        ///============== V Processes V ==============//
        void getAvaliablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cboPorts_Comm.Items.AddRange(ports);
        }
        ///====== V Open/Close PORTS V ======//
        // Open
        void openPort()
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = Convert.ToString(cboPorts_Comm.Text);
                serialPort1.BaudRate = 9600; // Important* set BaudRate from scale
                serialPort1.Parity = Parity.None; // Important* set Parity from scale
                serialPort1.Open();
            }
        }
        // close
        void closePort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose(); // clears
            }
        }
        ///=============== ^ Processes ^ ===============///

        ///============== V Menu Items V ==============//
        // Main
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            obj.Show();
            this.Hide();
        }
        ///============== V Select Port Box V ==============//
        // Button Check Device
        private void btnCheckDevice_Click(object sender, EventArgs e)
        {
            if (cboPorts_Comm.Text == "" || cboPorts_Comm.Text == " ")
            {
                txtOutput.Text = "Please select port!";
            }
            else
            {
                // Open Serial Port and check for errors
                try
                {
                    openPort();
                    lblDeviceStatus.Text = "Online"; // Shows Online
                                                     // Set Online image to green LED
                    pbDevice.Image = Image.FromFile("C:\\Users\\rapha\\repos\\LEDS\\green.png");
                    closePort();
                    //serialPort1.Dispose();
                }
                catch
                {
                    lblDeviceStatus.Text = "Connection Error"; // Shows Offline
                    pbDevice.Image = Image.FromFile("C:\\Users\\rapha\\repos\\LEDS\\red.png"); // Set Offline image to red LED
                }
            }
        }

        ///====== V Referesh Button V ======//
        // This will run the same task as when window opens
        // In case user does not have device connected when app starts
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            closePort();
            cboPorts_Comm.SelectedIndex = -1; // Clears selected item
            cboPorts_Comm.Items.Clear(); // Clears Ports Drop down
            getAvaliablePorts(); // checks for open ports and sends to combobox
        }
        ///========= ^ Select Port Box ^ ===========///

        ///============== V Open/Close Ports V ==============//

        // Open
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            statusBar.Value = 10;
            try
            {
                if (cboPorts_Comm.Text == "" || cboPorts_Comm.Text == " ")
                {
                    // Grey's out input/output boxes
                    txtOutput.Enabled = false;
                    txtOutput.Text = "Please select port settings!"; // Message
                }
                else
                {
                    statusBar.Value = 25;
                    try
                    {
                        openPort(); // Opens port
                        statusBar.Value = 100; // status bar

                        // Enables input/output boxes
                        txtOutput.Enabled = true;
                        btnRecieve.Enabled = true;
                        btnClosePort.Enabled = true;
                        btnTesting.Enabled = true;
                        txtOutput.Text = cboPorts_Comm.Text + " " + "Following...";
                    }
                    catch
                    {
                        // Throw Error
                        txtOutput.Enabled = true;
                        statusBar.Value = 10; // Status Bar
                        txtOutput.Text = "ERROR... Port did not open";
                    }
                }
            }
            catch
            {
                txtOutput.Text = "Unauthorized Access";
            }
        }
        // Close
        private void btnClosePort_Click(object sender, EventArgs e)
        {
            closePort();

            if (serialPort1.IsOpen)
            {
                txtOutput.Text = "Port is still open";
            }
            else
            {
                // Grey out options
                txtOutput.Enabled = false;
                btnClosePort.Enabled = false;
                btnRecieve.Enabled = false;
                statusBar.Value = 0; // Sets Status Bar
            }
        }

        ///========= ^ Open/Close Ports Buttons ^ ===========///

        ///============== V Scale Response Button V ==============//

        // btn Recieve
        // Does the proccessing for the scale output data
        private void btnRecieve_Click_1(object sender, EventArgs e)
        {
            // Local Var's
            string screenOutput = ""; // Init scale output
            double scaleIntConverted = 1; // Sets the scale weight that will be used to compare

            // Process that will grab scale data and convert it
            void grabScaleData()
            {
                string scaleOutput = serialPort1.ReadLine(); // ReadLine is needed to read serialports *important*
                screenOutput = Regex.Replace(scaleOutput, @"[^-?0-9.,]", ""); // Regex to remove scale's "SS" digits
                txtOutput.Text = screenOutput;
                scaleIntConverted = Convert.ToDouble(screenOutput);
            }

            if (txtWeightLimit.Text != "")
            {
                // Local Var's
                bool portOpen = true;
                double desiredAmount = Convert.ToDouble(txtWeightLimit.Text); // Sets user input to a double

                // Checks if port is open
                if (serialPort1.IsOpen)
                {
                    portOpen = true;
                }
                // Loops until the scale reaches user's desired amount
                while (portOpen == true)
                {
                    try
                    {
                        grabScaleData();
                    }
                    catch
                    {
                        closePort();
                        openPort();
                        grabScaleData();
                    }

                    // This will check if the user's ammout is reached and logs it to the screen
                    if (scaleIntConverted == desiredAmount || scaleIntConverted >= desiredAmount)
                    {
                        closePort(); // Closes connection to Scale
                        portOpen = false; // Set to stop loop
                        txtOutput.Text = Convert.ToString(scaleIntConverted); // Output amount used
                    }
                }
            }
            else
            {
                txtOutput.Text = "Please Input a weight limit";
            }
            openPort();
        }
        ///============== V SignalR Testing Area V =============//
        //~~~~~~~Processes~~~~~~//
        // Gets Hub Messages
        void hubMessages(string x)
        {
            txtSignalRReturn.AppendText(x);
        }

        // Connects to SignalR Server
        void connectSignalR()
        {
            _connection.Start(); // Starts SignalR Connection
                                 // Current message
            var toFront = txtSignalRMessage.Text;

            // Solves Cross threading issue
            var uiCtx = SynchronizationContext.Current;
            _hub.On("recieveMessage", x =>
            {
                    // You are no longer on the UI thread, so you have to post back to it
                    uiCtx.Post(_ =>
                {
                        // Put all code that touches the UI here
                        hubMessages(x);
                }, null);
            });
        }
        //~~~~~~~Buttons~~~~~~//
        // used to connect to hub
        private void btnSignalRConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connectSignalR();
                btnSignalRMessage.Enabled = true;
                pbarSignalR.Value = 100;

            }
            catch
            {
                pbarSignalR.Value = 40;
            }
        }
        // For sending edited message to server
        private void btnSignalRMessage_Click(object sender, EventArgs e)
        {

        }
    }
    ///============== V Important Scale Info V =============//
    //serialPort1.WriteLine("T\r\n"); // sets amount to zero
    ///============== V Testing V ==============//
    ///============== V Dump Code V ==============//
}

