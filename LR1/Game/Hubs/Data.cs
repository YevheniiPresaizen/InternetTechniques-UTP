using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Hubs
{
    public class Data : Hub
    {
        public async Task ChangeColor(int id, string color)
        {
            await Clients.All.SendAsync("ChangeColorInBrowser", id, color);
        }
    }
}
