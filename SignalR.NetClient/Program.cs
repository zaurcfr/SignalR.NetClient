using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SignalR.NetClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connection = new HubConnectionBuilder().WithAutomaticReconnect().WithUrl("https://localhost:5001/chatHub").Build();
            await connection.StartAsync();

            connection.On<string>("Open", (message) =>
            {
                Console.WriteLine(message);
            });
            Console.ReadLine();
        }
    }
}
