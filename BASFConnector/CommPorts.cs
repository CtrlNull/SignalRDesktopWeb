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

namespace BASFConnector
{
    public partial class CommPorts : Form
    {
        ///~~~ Main ~~~///
        public CommPorts()
        {
            InitializeComponent();
            getAvaliablePorts();
            txtOutput.Enabled = false;
            btnRecieve.Enabled = false;
            btnClosePort.Enabled = false;
            button1.Enabled = false;
            statusBar.Value = 0;
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
            serialPort1.PortName = Convert.ToString(cboPorts_Comm.Text);
            serialPort1.BaudRate = 9600; // Important* set BaudRate from scale
            serialPort1.Parity = Parity.None; // Important* set Parity from scale
            serialPort1.Open();
        }
        // close
        void closePort()
        {
            serialPort1.Close();
            serialPort1.Dispose(); // clears
        }

        ///============== V Menu Items V ==============//
        // Main
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            obj.Show();
            this.Hide();
        }
        // Serial Port Option
        private void serialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPortToolStripMenuItem.Enabled = false;
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
                        button1.Enabled = true;
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

        ///============== V Text boxes V ==============//
        // Input
        // Output
        // Currently the btn Recieve does the proccessing for the scale output data
        private void btnRecieve_Click_1(object sender, EventArgs e)
        {
            // Local var's to compare ammounts
            //string desiredAmount = "19.7";
            string screenOutput = "";

            //Loop until the scale reads the desired ammount
            while (screenOutput != "50.0")
            {
                // Following will take the scale's string then convert using REGEX to a readable string
                string scaleOutput = serialPort1.ReadLine();
                screenOutput = Regex.Replace(scaleOutput, @"[^-?0-9.,]", "");
                txtOutput.Text = screenOutput;
                // Stop the Scale when amount reaches user's desired ammount
            }
        }
        ///============== V Testing V ==============//

        // Button 1 is for testing purposes(not to lose data)
        private void button1_Click(object sender, EventArgs e)
        {
            string screenOutput = ""; // Init scale output
            double scaleIntConverted = 1; // Sets the scale weight that will be used to compare

            if (txtWeightLimit.Text != "")
            {
                double desiredAmount = Convert.ToDouble(txtWeightLimit.Text); // Sets user input to a double

                // Loops until the scale reaches user's desired amount
                while (desiredAmount != scaleIntConverted)
                {
                    string scaleOutput = serialPort1.ReadLine(); // ReadLine is needed to read serialports *important*
                    screenOutput = Regex.Replace(scaleOutput, @"[^-?0-9.,]", ""); // Regex to remove scale's "SS" digits
                    txtOutput.Text = screenOutput;
                    scaleIntConverted = Convert.ToDouble(screenOutput);

                    // THis will check if the user's ammout is reached and logs it to the screen
                    if (scaleIntConverted == desiredAmount || scaleIntConverted >= desiredAmount)
                    {
                        //serialPort1.Close();
                        txtOutput.Text = Convert.ToString(scaleIntConverted);
                    }
                }
            }
            else
            {
                txtOutput.Text = "Please Input a weight limit";
            }
        }
    }
    ///============== V Dump Code V ==============//
}

