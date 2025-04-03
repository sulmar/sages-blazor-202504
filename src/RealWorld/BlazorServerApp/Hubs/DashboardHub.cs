using Microsoft.AspNetCore.SignalR;

namespace BlazorServerApp.Hubs;

public class DashboardHub : Hub
{
    private readonly ILogger<DashboardHub> logger;

    public DashboardHub(ILogger<DashboardHub> logger)
    {
        this.logger = logger;
    }

    public override Task OnConnectedAsync()
    {
        // zła praktyka
        // Console.WriteLine($"Connected {Context.ConnectionId}");

        // zła praktyka
        // logger.LogInformation($"Connected {Context.ConnectionId}");

        // dobra praktyka
        logger.LogInformation("Connected {ConnectionId}", Context.ConnectionId);

        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        logger.LogInformation("Disconnected {ConnectionId}", Context.ConnectionId);

        return base.OnDisconnectedAsync(exception);
    }


}
