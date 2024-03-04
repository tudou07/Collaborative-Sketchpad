using Microsoft.AspNetCore.SignalR;

namespace SignalR1.Hubs
{
    public class DrawDotHub : Hub
    {
        // Add something to the canvas
        public async Task UpdateCanvas(int x, int y)
        {
            await Clients.All.SendAsync("updateDot", x, y);
        }

        // Clear the canvas
        public async Task ClearCanvas()
        {
            await Clients.All.SendAsync("clearCanvas");
        }
    }
}