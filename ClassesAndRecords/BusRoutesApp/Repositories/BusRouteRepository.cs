using BusRoutesApp.Entities;

namespace BusRoutesApp.Repositories
{
    public class BusRouteRepository : IBusRouteRepository
    {
        private readonly List<BusRoute> _allRoutes;
        private readonly SortedDictionary<int, BusRoute> _routesReffence;
        public BusTimes BusTimesRoute39 { get; }

        public BusRouteRepository()
        {

            _allRoutes = new()
            {
                new(40, new string[] { "Petrzalka", "Cintorin Slavicie", "Zoo", "Most SNP", "Most Apolo" }),
                new(41, new string[] { "Petrzalka", "Zelezna studenka", "Lanfranconi", "Patronka", "Cerveny most" }),
                new(192, new string[] { "Zoo", "Patronka", "Habansky Mlyn", "Suchy Mlyn" }),
                new(39, new string[] { "Cintorin slavicie", "Suhvezdena", "Zoo", "Lanfranconi", "Zochova", "Blumental" })
            };
            _routesReffence = new()
            {
                { 40, _allRoutes[0] },
                { 41, _allRoutes[1] },
                { 192, _allRoutes[2] },
                { 39, _allRoutes[3] }
            };
            string[][] timeRoute39 =
            {
             new string[] {"7:04", "7:14", "7:24", "7:34", "7:44", "7:54" },
             new string[] {"8:04", "8:14", "8:24", "8:34", "8:44", "8:54" },
             new string[] {"9:04", "9:14", "9:24", "9:34", "9:44", "9:54" },
             new string[] {"10:04", "10:14", "10:24", "10:34", "10:44", "10:54" },
             new string[] {"11:04", "11:14", "11:24", "11:34", "11:44", "11:54" },
             new string[] {"12:04", "12:14", "12:24", "12:34", "12:44", "12:54" }
            };

            BusTimesRoute39 = new BusTimes(_allRoutes[3], timeRoute39);
        }

        public int Count()  => _allRoutes.Count;

        public List<BusRoute> GetAll()
        {
            return _allRoutes;
        }

        public BusTimes GetBusTimes() => BusTimesRoute39;

        public BusRoute? FindByNumber(int routeNumber)
        {
            _routesReffence.TryGetValue(routeNumber, out var route);

            return route;
        }

        public List<BusRoute> FindBusesTo(string location)
        {
            return _allRoutes.FindAll((route) => route.Serves(location));
        }

        public int RemoveAllRoutesTo(string location)
        {
            return _allRoutes.RemoveAll(route => route.Serves(location));
        }

        public List<BusRoute> FindBusesBetween(string location1, string location2)
        {
            return _allRoutes.FindAll(route => route.Serves(location1) && route.Serves(location2));
        }
    }
}
