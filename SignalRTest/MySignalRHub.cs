using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRTest
{
    public class MySignalRHub:Hub
    {
        public void SendMessage(string name,string Message)
        {
            Clients.All.ShowMessageClients(name,Message);
        }
    }
}