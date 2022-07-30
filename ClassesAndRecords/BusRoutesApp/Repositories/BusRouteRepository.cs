using BusRoutesApp.Entities;

namespace BusRoutesApp.Repositories
{
    public class BusRouteRepository : IBusRouteRepository
    {
        private readonly List<BusRoute> _allRoutes;
        private readonly SortedDictionary<int, BusRoute> _routesReffence;

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
        }

        public int Count()
        {
            return _allRoutes.Count;
        }

        public List<BusRoute> GetAll()
        {
            return _allRoutes;
        }

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
    }
}
