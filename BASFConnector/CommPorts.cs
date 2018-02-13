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
        }
        // === {{ Processes }} === //
        void getAvaliablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cboPorts_Comm.Items.AddRange(ports);
        }


        // ------ Btn Handlers ------ //

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
                    Port = new SerialPort(Port_Number);
                    Port.BaudRate = 115200;
                    Port.DataBits = 8;
                    Port.Parity = Parity.None;
                    Port.StopBits = StopBits.One;
                    Port.Handshake = Handshake.None;
                    Port.DtrEnable = true;
                    Port.NewLine = Environment.NewLine;
                    Port.ReceivedBytesThreshold = 1024;
                    Port.Open();
                    lblDeviceStatus.Text = "Online"; // Shows Online
                                                     // Set Online image to green LED
                    pbDevice.Image = Image.FromFile("C:\\Users\\rapha\\repos\\LEDS\\green.png");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // Button to open the port
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPorts_Comm.Text == "" || cboPorts_Comm.Text == " " )
                {
                    txtOutput.Text = "Please select port settings!";
                }
                else
                {
                    //txtOutput.PortName = cboPorts_Comm.Text;
                }
            }
            catch
            {
                // finish this
            }
        }
        //////////////////// Unused Buttons //////////////////////
        private void cboPorts_Comm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
