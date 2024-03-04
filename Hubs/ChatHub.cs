using Microsoft.AspNetCore.SignalR;

namespace SignalR1.Hubs
{
    public class ChatHub : Hub
    {
        // This takes user (who's the user) abd it's message
        public async Task SendMessage(string user, string message)
        {
            // This sends the message to all the clients, we can call all, groupd and the caller just with Clients.method_name
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}