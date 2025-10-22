using Microsoft.AspNetCore.SignalR;

namespace signalr_chat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("Receive Message", user, message);
        }
    }
}
