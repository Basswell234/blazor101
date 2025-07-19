using System;

namespace BlazorApp.Models;

public class Server
{
    public Server()
    {
        Random random = new Random();
        int randomnumber = random.Next(0, 2);
        IsOnline = randomnumber == 0? false : true;
    }
    public int ServerId { get; set; }
    public string? Name { get; set; }
    public bool IsOnline { get; set; }
    public string? City { get; set; }
}
