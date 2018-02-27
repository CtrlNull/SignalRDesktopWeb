using Microsoft.AspNet.SignalR.Client;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASFConnector
{
    public partial class SignalR : Form
    {
        private HubConnection _connection;
        private IHubProxy _hub;

        public SignalR()
        {
            InitializeComponent();
            viewLogsToolStripMenuItem.Enabled = false;
            sendLogsToolStripMenuItem.Enabled = false;
            contactUsToolStripMenuItem.Enabled = false;
            signalRToolStripMenuItem.Enabled = false;
            btnConnectScale.Enabled = false;

            // SignalR initializing
            string url = @"http://signalrconnector.azurewebsites.net/"; // Make sure this matches the clientside web browser Ip**
            _connection = new HubConnection(url);
            _hub = _connection.CreateHubProxy("ConnectorHub");

            // try/catch to check if the device is connected
            try
            {
                openPort();
            }
            catch
            {
                txtLiveCOM.Text = "COM5 isnt Connected, Restart";
            }
            //

            //
            //  connectSignalR();
            // This is for original bug which would throw an error for scale input = ""
            //if (serialPort1.ReadLine() == "")
            //{
            //    closePort();
            //    openPort();
            //    scaleData(); // Connects to scale

            //}


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
                txtLiveCOM.Text = "COM5 is Connected";
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
        // Reads scale data
        void scaleData()
        {
            // Local Var's
            string screenOutput = ""; // Init scale output
            double scaleIntConverted = 1; // Sets the scale weight that will be used to compare
            string weightLimit = "100";


            // Process that will grab scale data and convert it
            void grabScaleData()
            {
                string scaleOutput = serialPort1.ReadLine(); 
                screenOutput = Regex.Replace(scaleOutput, @"[^-?0-9.,]", ""); // Regex to remove scale's "SS" digits
                lblScaleWeight.Text = screenOutput;
                scaleIntConverted = Convert.ToDouble(screenOutput); // Convert for while loop

                _connection.Start(); // Starts SignalR Connection
                _hub.Invoke("sendMessage", screenOutput);

            }

            //async Task ReadScaleWait()
            //{
            //    string scaleOutput = await serialPort1.ReadLine(); // ReadLine is needed to read serialports *important*
            //    screenOutput = Regex.Replace(scaleOutput, @"[^-?0-9.,]", ""); // Regex to remove scale's "SS" digits
            //    lblScaleWeight.Text = screenOutput;
            //    _connection.Start(); // Starts SignalR Connection
            //    _hub.Invoke("sendMessage", screenOutput);

            //    scaleIntConverted = Convert.ToDouble(screenOutput);

            //}



            if (weightLimit != "")
            {
                // Local Var's
                bool portOpen = true;
                double desiredAmount = Convert.ToDouble(weightLimit); // Sets user input to a double

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
                        lblScaleWeight.Text = Convert.ToString(scaleIntConverted); // Output amount used
                    }
                }
            }
            else
            {
                // Nothing
            }
            openPort();
        }
        ///==================== ^ Processes ^ ===================///

        ///===================== V Buttons V ====================//
        // Btn for Scale Connection
        private void btnConnectScale_Click(object sender, EventArgs e)
        {
            try
            {
                scaleData();
            }
            catch
            {
                txtScaleErrors.Text = "Error connecting to scale";
            }

        }
        // Btn for SignalR Connection
        private void btnConnectSignalR_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Start(); // Starts SignalR Connection
                txtSignalRStatus.Text = null;
                txtSignalRStatus.Text = "SignalR Hub is Connected";
                btnConnectScale.Enabled = true;
            }
            catch
            {
                txtSignalRStatus.Text = null;
                txtSignalRStatus.ForeColor = Color.Red;
                txtSignalRStatus.Text = "Cannot Find SignalR Hub";
            }

        }
    }
}
