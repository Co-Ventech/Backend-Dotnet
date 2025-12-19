using Microsoft.AspNetCore.SignalR;

namespace BackendBoilerplate.Services
{
    public class ExampleHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}