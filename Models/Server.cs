using System;

namespace BlazorApp.Models;

public class Server
{
    public Server(int serverId, string? name, bool isOnline, string? city)
    {
        Random random = new Random();
        int randomnumber = random.Next(0, 2);
        isOnline = randomnumber == 0? false : true;
    }
    public int ServerId { get; set; }
    public string? Name { get; set; }
    public bool IsOnline { get; set; }
    public string? City { get; set; }
}
