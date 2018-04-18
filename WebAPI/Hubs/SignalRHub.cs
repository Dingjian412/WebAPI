using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading.Tasks;
using WebAPI.Models;


namespace WebAPI.Hubs
{
    //[HubName("SignalRHub")]
    public class SignalRHub : Hub
    {
        public void Hello()
        {
            //Send all signal to all signalR Client "Hello".
            //Clients.All.hello();
        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        public void UpdateMarkup(string eventId, string teamId, string x, string y)
        {
            Clients.All.broadcast(eventId, teamId, x, y);
        }

    }
}