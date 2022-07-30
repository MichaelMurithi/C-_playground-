using BusRoutesApp.Entities;

namespace BusRoutesApp.Repositories
{
    public interface IBusRouteRepository
    {
        int Count();
        List<BusRoute> GetAll();
        BusTimes GetBusTimes();
        List<BusRoute> FindBusesTo(string location);
        BusRoute? FindByNumber(int routeNumber);
        int RemoveAllRoutesTo(string location);
        List<BusRoute> FindBusesBetween(string location1, string location2);
    }
}
