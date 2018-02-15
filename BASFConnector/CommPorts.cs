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
            txtInput.Enabled = false;
            txtOutput.Enabled = false;
            btnSend.Enabled = false;
            btnRecieve.Enabled = false;
            btnClosePort.Enabled = false;
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
                    txtInput.Enabled = false;
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
                        txtInput.Enabled = true;
                        txtOutput.Enabled = true;
                        btnSend.Enabled = true;
                        btnRecieve.Enabled = true;
                        btnClosePort.Enabled = true;
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
                txtInput.Enabled = false;
                txtOutput.Enabled = false;
                btnClosePort.Enabled = false;
                btnSend.Enabled = false;
                btnRecieve.Enabled = false;
                statusBar.Value = 0; // Sets Status Bar
            }
        }

        ///========= ^ Open/Close Ports Buttons ^ ===========///

        ///============== V Text boxes V ==============//
        // Input
        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txtInput.Text);
            txtInput.Text = "";

        }
        // Output
        private void btnRecieve_Click_1(object sender, EventArgs e)
        {
            // Local var's to compare ammounts
            string desiredAmount = "19.7";
            string screenOutput = "";

            //Loop until the scale reads the desired ammount
            while (screenOutput != desiredAmount)
            {
                // Following will take the scale's string then convert using REGEX to a readable string
                string scaleOutput = serialPort1.ReadLine();
                screenOutput = Regex.Replace(scaleOutput, @"[^-?0-9.,]", " ");
                txtOutput.Text = screenOutput;
            }
        }
    }
    ///============== V Dump Code V ==============//
}

