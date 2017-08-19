using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRTest
{
    public class MyHub:Hub
    {
        public void Chat(string name,string Message)
        {
            Clients.All.SendChat(name, Message);
        }
    }
}