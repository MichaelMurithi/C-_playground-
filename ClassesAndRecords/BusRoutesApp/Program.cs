using BusRoutesApp.Entities;
using BusRoutesApp.Repositories;

class Program
{
    static void Main(string[] args)
    {
        List<BusRoute> busRoutes = BusRouteRepository.InitializeRoutes();
        CleanUpRoutes(busRoutes);
        FindBusRoute(busRoutes.ToArray());
    }

    private static void CleanUpRoutes(List<BusRoute> routes)
    {
        Console.WriteLine($"\r\nBefore: There are {routes.Count} routes:");
        Show(routes);

        Console.WriteLine("\r\nWhich destination do you want to remove?");
        string location = Console.ReadLine() ?? string.Empty;

        if (location == string.Empty)
        {
            Console.WriteLine("\nSorry, we could not figure out the destination you want to remove");
            return;
        }

        routes.RemoveAll(route => route.Serves(location));

        Console.WriteLine($"\r\nAfter removing routes serving {location} there {(routes.Count > 1 ? "are" : "is")} {routes.Count} routes");
        Show(routes);
    }

    private static void FindBusRoute(BusRoute[] busRoutes)
    {
        Console.WriteLine("\r\nWhere do you want to go to?");
        string? destination = Console.ReadLine();

        if (destination == null)
        {
            Console.WriteLine("\r\nSorry, we could not figure out your destination");
            return;
        }

        BusRoute[]? routes = FindBusesTo(busRoutes, destination);

        if (routes?.Length > 0)
            foreach (var route in routes)
                Console.WriteLine($"\r\nYou can use route {route}");
        else
            Console.WriteLine($"\r\nNo routes go to {destination}");
    }

    private static BusRoute[]? FindBusesTo(BusRoute[] routes, string location)
    {
        return Array.FindAll(routes, (route) => route.Serves(location)); 
    }

    private static void Show(List<BusRoute> routes)
    {
        Console.WriteLine("\n");

        for (int i =0; i < routes.Count; i++ )
            Console.WriteLine($"{i+1}. Route: {routes[i]}");
    }
}
