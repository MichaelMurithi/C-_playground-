using BusRoutesApp.Entities;

namespace BusRoutesApp.Repositories
{
    public class BusRouteRepository
    {
        public static SortedDictionary<int, BusRoute> InitializeRoutes()
        {
            var routesList = GetRoutesList();
            var routes = new SortedDictionary<int, BusRoute>
            {
                { 40, routesList[0] },
                { 41, routesList[1] },
                { 192, routesList[2] },
                { 39, routesList[3] }
            };

            return routes;
        }

        public static List<BusRoute> GetRoutesList()
        {
            List<BusRoute> routes = new()
            {
                new(40, new string[] { "Petrzalka", "Cintorin Slavicie", "Zoo", "Most SNP", "Most Apolo" }),
                new(41, new string[] { "Petrzalka", "Zelezna studenka", "Lanfranconi", "Patronka", "Cerveny most" }),
                new(192, new string[] { "Zoo", "Patronka", "Habansky Mlyn", "Suchy Mlyn" }),
                new(39, new string[] { "Cintorin slavicie", "Suhvezdena", "Zoo", "Lanfranconi", "Zochova", "Blumental" })
            };

            return routes;
        }
    }
}
