using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

public class SignalRService
{
    private readonly HubConnection _hubConnection;

    public event Action<string> OnMessageReceived;

    public SignalRService(NavigationManager navigationManager)
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl(navigationManager.ToAbsoluteUri("/notificationHub")) // Correct path to your SignalR Hub
            .Build();

    }

    public async Task StartAsync()
    {
        try
        {
            await _hubConnection.StartAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error starting SignalR connection: {ex.Message}");
        }

        _hubConnection.On<string>("ReceiveMessage", (message) =>
        {
            OnMessageReceived?.Invoke(message);
        });
    }

    public async Task StopAsync()
    {
        await _hubConnection.StopAsync();
    }
}
