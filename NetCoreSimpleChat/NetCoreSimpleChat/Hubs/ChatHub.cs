using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreSimpleChat.Hubs
{
    public class ChatHub : Hub
    {

        public void SendMessage(string user, string message)
        {
            if (String.IsNullOrEmpty(user))
            {
                user = "DefaultGuest";
            }
            Clients.All.SendAsync("Messages", user, message);
        }
    }
}
