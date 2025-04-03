
using BlazorServerApp.Hubs;
using BlazorServerApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace BlazorServerApp.BackgroundServices;

public class DashboardBackgroundService : BackgroundService
{
    private readonly ILogger<DashboardBackgroundService> logger;
    private readonly IHubContext<DashboardHub> hubContext;

    public DashboardBackgroundService(ILogger<DashboardBackgroundService> logger, IHubContext<DashboardHub> hubContext)
    {
        this.logger = logger;
        this.hubContext = hubContext;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var info = new Info
            {
                TotalSales = Random.Shared.Next(0, 1_000_000),
                NewUsers = Random.Shared.Next(0, 10),
                ActiveSessions = Random.Shared.Next(0, 10),
            };

            logger.LogInformation("TotalSales: {TotalSales}, NewUsers: {NewUsers}, ActiveSessions: {ActiveSessions}", info.TotalSales, info.NewUsers, info.ActiveSessions);

            await hubContext.Clients.All.SendAsync("DashboardChanged", info);

            await Task.Delay(Random.Shared.Next(500, 2000));


        }
    }
}
