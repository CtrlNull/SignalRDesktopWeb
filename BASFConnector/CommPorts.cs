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

            // Search for ports and display on ComboBox
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts_Comm.Items.Add(ArrayComPortsNames[index]);
            }

            while (!((ArrayComPortsNames[index] == ComPortName)
                          || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);


            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            cboPorts_Comm.Text = ArrayComPortsNames[0]; // Outputs Port names on Combo list

            //SerialPort Port;

            // string Port_Number = 


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

        private void cboPorts_Comm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckDevice_Click(object sender, EventArgs e)
        {
            // Simple add selected comboBox to Label
            string String = cboPorts_Comm.SelectedItem.ToString();
            lblSelected.Text = String;

            // Set Serial Port(COMM) from selected item
            SerialPort Port;
            string Port_Number = String;

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
                lblDeviceStatus.Text = "Online";
            }
            catch
            {
                lblDeviceStatus.Text = "Connection Error";
                //Port.Dispose();
            }

        }
    }
}
