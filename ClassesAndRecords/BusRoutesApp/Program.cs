using BusRoutesApp.Entities;
using BusRoutesApp.Repositories;

class Program
{
    static void Main(string[] args)
    {
        BusRoute[] busRoutes = BusRouteRepository.InitializeRoutes();

        FindBusRoute(busRoutes);
    }

    private static void FindBusRoute(BusRoute[] busRoutes)
    {
        Console.WriteLine("Where do you want to go to?");
        string? destination = Console.ReadLine();

        if (destination == null)
        {
            Console.WriteLine("\nSorry, we could not figure out your destination");
            return;
        }

        BusRoute[]? routes = FindBusesTo(busRoutes, destination);

        if (routes?.Length > 0)
            foreach (var route in routes)
                Console.WriteLine($"\nYou can use route {route}");
        else
            Console.WriteLine($"\nNo routes go to {destination}");
    }

    public static BusRoute[]? FindBusesTo(BusRoute[] routes, string location)
    {
        return Array.FindAll(routes, (route) => route.Serves(location)); 
    }
}
