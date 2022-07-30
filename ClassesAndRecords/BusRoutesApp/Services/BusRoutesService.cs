using BusRoutesApp.Entities;
using BusRoutesApp.Repositories;

namespace BusRoutesApp.Services
{
    public class BusRoutesService : IBusRoutesService
    {
        private IBusRouteRepository _routesRepository;

        public BusRoutesService(IBusRouteRepository repository)
        {
            _routesRepository = repository;
        }
        public void CleanUpRoutes()
        {
            Console.WriteLine($"\r\nBefore: There are {_routesRepository.Count} routes:");
            Show(_routesRepository.GetAll());

            Console.WriteLine("\r\nWhich destination do you want to remove?");
            string location = Console.ReadLine() ?? string.Empty;

            if (location == string.Empty)
            {
                Console.WriteLine("\nSorry, we could not figure out the destination you want to remove");
                return;
            }

            _routesRepository.RemoveAllRoutesTo(location);

            Console.WriteLine($"\r\nAfter removing routes serving {location} there {(_routesRepository.Count() > 1 ? "are" : "is")} {_routesRepository.Count()} route(s) available");
            Show(_routesRepository.GetAll());
        }

        public void FindBusRoute()
        {
            Console.WriteLine("\r\nWhere do you want to go to?");
            string? destination = Console.ReadLine();

            if (destination == null)
            {
                Console.WriteLine("\r\nSorry, we could not figure out your destination");
                return;
            }

            var routes = _routesRepository.FindBusesTo(destination);

            if (routes?.Count > 0)
                foreach (var route in routes)
                    Console.WriteLine($"\nYou can use route {route}");
            else
                Console.WriteLine($"\nNo routes go to {destination}");
        }

        public void FindRouteByNumber()
        {
            Console.WriteLine("\r\nWhich route do you want to look up?");
            int routeNumber = int.Parse(Console.ReadLine() ?? "");

            var route = _routesRepository.FindByNumber(routeNumber);

            if (route != null)
                Console.WriteLine($"\nThe root you asked for is {route}");
            else
                Console.WriteLine($"\nThere is no route with number {routeNumber}");
        }

        public void FindConnection()
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

            var originRoutes = _routesRepository.FindBusesTo(startingAt);
            var destinationRoutes = _routesRepository.FindBusesTo(goingTo);

            HashSet<BusRoute> routes = new HashSet<BusRoute>(originRoutes);
            routes.IntersectWith(destinationRoutes);

            if (routes?.Count > 0)
                foreach (var route in routes)
                    Console.WriteLine($"\nYou can use route {route}");
            else
                Console.WriteLine($"\nNo routes from {startingAt} go to {goingTo}");
        }

        public void ShowBusTimes39()
        {
            BusTimes schedule39 = _routesRepository.GetBusTimes();
            BusRoute route39 = schedule39.Route;

            Console.WriteLine("\r\nToday's shedule for bus 39:\n");

            for (int iPlace = 0; iPlace < route39.PlacesServed.Length; iPlace++)
            {
                Console.Write(route39.PlacesServed[iPlace].PadRight(20));

                foreach (string time in schedule39.Times[iPlace])
                    Console.Write(time.PadRight(6));

                Console.WriteLine();
            }
        }

        private static void Show(List<BusRoute> routes)
        {
            Console.WriteLine("\n");

            for (int i = 0; i < routes.Count; i++)
                Console.WriteLine($"{i + 1}. Route: {routes[i]}");
        }
    }
}
