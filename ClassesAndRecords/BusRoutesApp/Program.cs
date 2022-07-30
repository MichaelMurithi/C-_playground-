using BusRoutesApp.Entities;
using BusRoutesApp.Repositories;

class Program
{
    static void Main(string[] args)
    {
        IBusRouteRepository routesRepository = new BusRouteRepository();

        FindRouteByNumber(routesRepository);
        CleanUpRoutes(routesRepository);
        FindConnection(routesRepository);
    }

    private static void CleanUpRoutes(IBusRouteRepository routesRepository)
    {
        Console.WriteLine($"\r\nBefore: There are {routesRepository.Count()} routes:");
        Show(routesRepository.GetAll());

        Console.WriteLine("\r\nWhich destination do you want to remove?");
        string location = Console.ReadLine() ?? string.Empty;

        if (location == string.Empty)
        {
            Console.WriteLine("\nSorry, we could not figure out the destination you want to remove");
            return;
        }

        routesRepository.RemoveAllRoutesTo(location);

        Console.WriteLine($"\r\nAfter removing routes serving {location} there {(routesRepository.Count() > 1 ? "are" : "is")} {routesRepository.Count()} route(s) available");
        Show(routesRepository.GetAll());
    }

    private static void FindBusRoute(IBusRouteRepository routesRepository)
    {
        Console.WriteLine("\r\nWhere do you want to go to?");
        string? destination = Console.ReadLine();

        if (destination == null)
        {
            Console.WriteLine("\r\nSorry, we could not figure out your destination");
            return;
        }

        var routes = routesRepository.FindBusesTo(destination);

        if (routes?.Count > 0)
            foreach (var route in routes)
                Console.WriteLine($"\nYou can use route {route}");
        else
            Console.WriteLine($"\nNo routes go to {destination}");
    }

    private static void FindRouteByNumber(IBusRouteRepository routesRepository)
    {
        Console.WriteLine("\r\nWhich route do you want to look up?");
        int routeNumber = int.Parse(Console.ReadLine() ?? "");

        var route = routesRepository.FindByNumber(routeNumber);

        if (route != null)
            Console.WriteLine($"\nThe root you asked for is {route}");
        else
            Console.WriteLine($"\nThere is no route with number {routeNumber}");
    }

    private static void FindConnection(IBusRouteRepository routesRepository)
    {
        Console.WriteLine("\r\nWhere are you?");
        string? startingAt = Console.ReadLine();

        Console.WriteLine("\r\nWhere do you want to go to?");
        string? goingTo = Console.ReadLine();

        if (startingAt == null || goingTo == null)
        {
            Console.WriteLine("\r\nSorry, we could not figure out your destination or location");
            return;
        }

        var routes = routesRepository.FindBusesBetween(startingAt, goingTo);

        if (routes?.Count > 0)
            foreach (var route in routes)
                Console.WriteLine($"\nYou can use route {route}");
        else
            Console.WriteLine($"\nNo routes from {startingAt} go to {goingTo}");
    }

    private static void Show(List<BusRoute> routes)
    {
        Console.WriteLine("\n");

        for (int i =0; i < routes.Count; i++ )
            Console.WriteLine($"{i+1}. Route: {routes[i]}");
    }
}
