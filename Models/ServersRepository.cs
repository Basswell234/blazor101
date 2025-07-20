using System;
using System.Security.Cryptography.X509Certificates;

namespace BlazorApp.Models;

public class ServersRepository
{
    public static List<Server> Servers { get; set; } = new List<Server>
    {
        new Server { ServerId = 1, Name = "Server 1", IsOnline = true, City = "New York" },
        new Server { ServerId = 2, Name = "Server 2", IsOnline = false, City = "Los Angeles" },
        new Server { ServerId = 3, Name = "Server 3", IsOnline = true, City = "New York"},
        new Server { ServerId = 4, Name = "Server 4", IsOnline = false, City = "Houston" },
        new Server { ServerId = 5, Name = "Server 5", IsOnline = true, City = "Miami" },
        new Server { ServerId = 6, Name = "Server 6", IsOnline = false, City = "Seattle" },
        new Server { ServerId = 7, Name = "Server 7", IsOnline = true, City = "Zambia" },
        new Server { ServerId = 8, Name = "Server 8", IsOnline = false, City = "Boston" },
        new Server { ServerId = 9, Name = "Server 9", IsOnline = true, City = "San Francisco" },
        new Server { ServerId = 10, Name = "Server 10", IsOnline = false, City = "New York" },
        new Server { ServerId = 11, Name = "Server 11", IsOnline = true, City = "Atlanta" },
        new Server { ServerId = 12, Name = "Server 12", IsOnline = false, City = "Phoenix" },
        new Server { ServerId = 13, Name = "Server 13", IsOnline = true, City = "Philadelphia" },
        new Server { ServerId = 14, Name = "Server 14", IsOnline = true, City = "South Africa" },
        new Server { ServerId = 15, Name = "Server 15", IsOnline = true, City = "Zambia" }
    };

    //Adding a new server with a unique ServerId
    public static void AddServer(Server server)
    {
        var maxId = Servers.Max(s => s.ServerId);
        server.ServerId = maxId + 1;
        Servers.Add(server);
    }

    //Method to get all servers
    public static List<Server> GetServers()
    {
        return Servers;
    }

    //Filtering servers by city
    public static List<Server> GetServersByCity(string city)
    {
        return Servers.Where(s => s.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    //Method to get a server by its ID
    public static Server? GetServerById(int id)
    {
        var server = Servers.FirstOrDefault(s => s.ServerId == id);
        if (server != null)
        {
            return new Server
            {
                ServerId = server.ServerId,
                Name = server.Name,
                IsOnline = server.IsOnline,
                City = server.City
            };
        }
        return null;
    }

    //Method to update a server
    public static void UpdateServer(int serverId, Server server)
    {
        if (serverId != server.ServerId) return;
        var serverToUpdate = Servers.FirstOrDefault(s => s.ServerId == serverId);
        if (serverToUpdate != null)
        {
            serverToUpdate.Name = server.Name;
            serverToUpdate.IsOnline = server.IsOnline;
            serverToUpdate.City = server.City;
        }
    }
    public static void DeleteServer(int serverId)
    {
        var serverToDelete = Servers.FirstOrDefault(s => s.ServerId == serverId);
        if (serverToDelete != null)
        {
            Servers.Remove(serverToDelete);
        }
    }
    public static List<Server> SearchServers(string serverFilter)
    {
        return Servers.Where(s => s.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
