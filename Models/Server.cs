using System;
using System.ComponentModel.DataAnnotations;

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
    
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }
    public bool IsOnline { get; set; }

    [Required(ErrorMessage = "City is required")]
    public string? City { get; set; }
}
