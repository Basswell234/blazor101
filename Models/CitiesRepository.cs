using System;

namespace BlazorApp.Models;

public class CitiesRepository
{
    public static List<string> Cities = new List<string>
    {
        "Chicago",
        "Zambia",
        "New York",
        "Paris",
    };

    // Method to get all cities
    public static List<string> GetCities()
    {
        return Cities;
    }
}
