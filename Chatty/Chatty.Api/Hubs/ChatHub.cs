﻿using Chatty.Api.Clients;
using Chatty.Api.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chatty.Api.Hubs
{
    public class ChatHub:Hub<IChatClient>
    {
        //public async Task SendMessage(ChatMessage message)
        //{
        //    await Clients.All.ReceiveMessage(message);
        //}
    }
}
