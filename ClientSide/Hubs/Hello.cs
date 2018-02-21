﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ClientSide.Hubs
{
    [HubName("ConnectorHub")]
    public class Hello : Hub
    {
        public void HelloSignalR()
        {
            this.Clients.All.helloClients("Hello!");
        }
    }
}