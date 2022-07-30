using BusRoutesApp.Entities;

namespace BusRoutesApp.Repositories
{
    public class BusRouteRepository
    {
        public static List<BusRoute> InitializeRoutes()
        {
            List<BusRoute> routes = new List<BusRoute>();
            
            routes.Add(new(40, new string[] { "Petrzalka", "Cintorin Slavicie", "Zoo", "Most SNP", "Most Apolo" }));
            routes.Add(new(41, new string[] { "Petrzalka", "Zelezna studenka", "Lanfranconi", "Patronka", "Cerveny most" }));
            routes.Add(new(192, new string[] { "Zoo", "Patronka", "Habansky Mlyn", "Suchy Mlyn" }));
            routes.Add(new(39, new string[] { "Cintorin slavicie", "Suhvezdena", "Zoo", "Lanfranconi", "Zochova", "Blumental" }));

            return routes;
        }
    }
}
