using BusRoutesApp.Entities;

namespace BusRoutesApp.Repositories
{
    public class BusRouteRepository
    {
        public static List<BusRoute> InitializeRoutes()
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
