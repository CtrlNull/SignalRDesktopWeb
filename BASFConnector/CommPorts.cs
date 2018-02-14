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
        // Run Open Port
        void openPort()
        {
            // Simple add selected comboBox to Label
            string String = cboPorts_Comm.SelectedItem.ToString();

            // Set Serial Port(COMM) from selected item
            SerialPort Port;
            string Port_Number = String;
            lblCOMM.Text = Port_Number;

            // Open Serial Port and check for errors
            // Settings for serialport
            Port = new SerialPort(Port_Number);
            Port.BaudRate = 9600;
            Port.Parity = Parity.None;
            Port.Open(); // Opened*
        }
        // Run Close Port
        void closePort()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Simple add selected comboBox to Label
            string String = cboPorts_Comm.SelectedItem.ToString();

            // Set Serial Port(COMM) from selected item
            SerialPort Port;
            string Port_Number = String;
            lblCOMM.Text = Port_Number;

            // Open Serial Port and check for errors
            Port = new SerialPort(Port_Number);
            Port.Close(); // Close Port
            Port.Dispose(); // Removes Port

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
            statusBar.Value = 0; // Sets Status Bar
            closePort();
        }

        ///===============================///
        // ===== [[ Text boxes ]] ===== //
        // Input
        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txtInput.Text);
            txtInput.Text = "";

        }
        // Output
        private void btnRecieve_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = serialPort1.ReadTo("\n");
            }
            catch (TimeoutException)
            {
                txtOutput.Text = "TimeOutException";
            }
        }


        // =============== TESTING =================== //
        private void btnSendTemp_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = "COM5";
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.Open();
                if(serialPort1.IsOpen)
                {
                    txtOutput.Text = "Open";
                }
                else
                {
                    txtOutput.Text = "closed";
                }

                //txtOutput.Text = serialPort1.ReadTo("\n");

                serialPort1.Close();
                serialPort1.Dispose();
            }
            catch (TimeoutException)
            {
                txtOutput.Text = "TimeOutException";
            }

        }
    }
}
