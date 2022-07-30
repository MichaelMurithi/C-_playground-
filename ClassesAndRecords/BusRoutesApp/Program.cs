using BusRoutesApp.Entities;
using BusRoutesApp.Repositories;

class Program
{
    static void Main(string[] args)
    {
        List<BusRoute> busRoutes = BusRouteRepository.GetRoutesList();
        SortedDictionary<int, BusRoute> routes = BusRouteRepository.InitializeRoutes();

        FindRouteByNumber(routes);
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

        Console.WriteLine($"\r\nAfter removing routes serving {location} there {(routes.Count > 1 ? "are" : "is")} {routes.Count} route(s) available");
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
                Console.WriteLine($"\nYou can use route {route}");
        else
            Console.WriteLine($"\nNo routes go to {destination}");
    }

    private static void FindRouteByNumber(SortedDictionary<int, BusRoute> allRoutes)
    {
        Console.WriteLine("\r\nWhich route do you want to look up?");
        int routeNumber = int.Parse(Console.ReadLine() ?? "");

        var routeExists = allRoutes.TryGetValue(routeNumber, out var answer);

        if (routeExists)
            Console.WriteLine($"\nThe root you asked for is {answer}");
        else
            Console.WriteLine($"\nThere is no route with number {routeNumber}");
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
