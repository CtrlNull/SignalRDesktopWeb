using Microsoft.AspNet.SignalR.Client;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASFConnector
{
    static class Program
    {
        // Main
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
        public class TestHub
        {
            
        }
        //public void BroadcastData(int a, string b, double c)
        //{
        //    // Do something with Clients or whatever here
        //}
    }
}
