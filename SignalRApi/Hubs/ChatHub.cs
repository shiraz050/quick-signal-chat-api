using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace SignalRApi.Hubs
{
    [Authorize] // Secure hub using JWT
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            var username = Context.User?.Identity?.Name ?? "Unknown";
            await Clients.All.SendAsync("UserConnected", username);
            await base.OnConnectedAsync();
        }

        public async Task SendMessage(string message)
        {
            var username = Context.User?.Identity?.Name ?? "Unknown";

            await Clients.All.SendAsync("ReceiveMessage", new
            {
                user = username,
                message = message,
                timestamp = DateTime.UtcNow
            });
        }
    }
}
