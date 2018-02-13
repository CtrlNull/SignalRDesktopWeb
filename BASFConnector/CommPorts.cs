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

namespace BASFConnector
{
    public partial class CommPorts : Form
    {
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
        // === {{ Processes }} === //
        void getAvaliablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cboPorts_Comm.Items.AddRange(ports);
        }

        void openPort()
        {
            serialPort1.PortName = cboPorts_Comm.Text; // Grabs drop down port and sets it
            serialPort1.BaudRate = Convert.ToInt32(115200); // Sets Baud Rate
            serialPort1.Open(); // Opened
        }

        // === {{Btn Handlers } === //

        //////// {  Menu Items } ////////
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

        // Button Check Device
        private void btnCheckDevice_Click(object sender, EventArgs e)
        {
            if (cboPorts_Comm.Text == "" || cboPorts_Comm.Text == " ")
            {
                txtOutput.Text = "Please select port!";
            }
            else
            {
                // Simple add selected comboBox to Label
                string String = cboPorts_Comm.SelectedItem.ToString();

                // Set Serial Port(COMM) from selected item
                SerialPort Port;
                string Port_Number = String;
                lblCOMM.Text = Port_Number;

                // Open Serial Port and check for errors
                try
                {
                    // Settings for serialport
                    Port = new SerialPort(Port_Number);
                    Port.BaudRate = 115200;
                    Port.DataBits = 8;
                    Port.Parity = Parity.None;
                    Port.StopBits = StopBits.One;
                    Port.Handshake = Handshake.None;
                    Port.DtrEnable = true;
                    Port.NewLine = Environment.NewLine;
                    Port.ReceivedBytesThreshold = 1024;
                    Port.Open(); // Opened*
                    lblDeviceStatus.Text = "Online"; // Shows Online
                                                     // Set Online image to green LED
                    pbDevice.Image = Image.FromFile("C:\\Users\\rapha\\repos\\LEDS\\green.png");
                    Port.Close(); // Closed**
                }
                catch
                {
                    lblDeviceStatus.Text = "Connection Error"; // Shows Offline
                                                               // Set Offline image to red LED
                    pbDevice.Image = Image.FromFile("C:\\Users\\rapha\\repos\\LEDS\\red.png");
                    //Port.Dispose();
                }
            }
        }

        // [[ Refresh Button ]] //
        // This will run the same task as when window opens
        // In case user does not have device connected when app starts
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboPorts_Comm.SelectedIndex = -1;
            cboPorts_Comm.Items.Clear(); // Clears Ports Drop down
            getAvaliablePorts(); // checks for open ports and sends to combobox
        }

        // ==== Open / Close Ports ==== //

        // Open
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            statusBar.Value = 10;
            try
            {
                if (cboPorts_Comm.Text == "" || cboPorts_Comm.Text == " " )
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
                        statusBar.BackColor = Color.Red;
                        statusBar.Value = 10;
                        txtOutput.Text = "ERROR... Port did not open";
                    }
                }
            }
            catch
            {
                txtOutput.Text = "Unauthorized Access";
                // finish this
            }
        }
        // Close
        private void btnClosePort_Click(object sender, EventArgs e)
        {
            // Grey out options
            txtInput.Enabled = false;
            txtOutput.Enabled = false;
            btnClosePort.Enabled = false;
            btnSend.Enabled = false;
            btnRecieve.Enabled = false;
            // Set Status bar
            statusBar.Value = 0;
            // Close any open ports
            serialPort1.Close();
        }

        ///===============================///

        //////////////////// Unused Buttons //////////////////////
        private void cboPorts_Comm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
