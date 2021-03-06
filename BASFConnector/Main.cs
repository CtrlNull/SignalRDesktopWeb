﻿using Microsoft.AspNet.SignalR.Client;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using Microsoft.AspNet.SignalR;

namespace BASFConnector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Disabled Menu Items
            viewLogsToolStripMenuItem.Enabled = false;
            sendLogsToolStripMenuItem.Enabled = false;
            contactUsToolStripMenuItem.Enabled = false;
            mainToolStripMenuItem.Enabled = false;

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
        ///============== V Processes V ==============//
        
        public void DetermindLength(string message)
        {
            Console.WriteLine(message);
        }
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
        // Checks port and closes
        void closePort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose();
            }
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
        ///===================== V Buttons V =======================//
        
        // Restart Btn //
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        // Scale Output //
        private void btnServerTesting_Click(object sender, EventArgs e)
        {
            // This is for original bug which would throw an error for scale input = ""
            if (serialPort1.ReadLine() == "")
            {
                closePort();
                openPort();
            }

            scaleData(); // Connects to scale
        }
        ///===================== V Menu Items V ====================//
        
        // Serial Port //
        private void smsSerialPort_Click(object sender, EventArgs e)
        {
            closePort();
            CommPorts obj = new CommPorts();
            obj.Show();
            this.Hide();
        }
        // SignalR //
        private void signalRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closePort();
            SignalR obj = new SignalR();
            obj.Show();
            this.Hide();
        }
    }
}
