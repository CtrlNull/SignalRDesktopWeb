using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASFConnector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\rapha\\repos\\Builds\\BASFConnectorConsole\\BASFConnectorConsole.exe");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IHubProxy _hub;
            string url = @"http://localhost:8080/";
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("TestHub");
            connection.Start().Wait();

        }
    }
}
