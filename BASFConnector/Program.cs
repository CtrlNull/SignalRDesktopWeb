using Microsoft.AspNet.SignalR.Client;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASFConnector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            IHubProxy _hub;
            string url = @"http://localhost:8080/";
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("TestHub");
            connection.Start().Wait();


        }
        public class TestHub
        {
            
        }
    }
}
