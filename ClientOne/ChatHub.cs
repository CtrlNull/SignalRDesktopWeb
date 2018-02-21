using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ClientOne
{
    public class ChatHub : Hub
    {
        public void HelloSignalR()
        {
            this.Clients.All.helloClient("HELLO !");
        }
    }
}