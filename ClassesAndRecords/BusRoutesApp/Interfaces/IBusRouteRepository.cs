using BusRoutesApp.Entities;

namespace BusRoutesApp.Repositories
{
    public interface IBusRouteRepository
    {
        int Count();
        List<BusRoute> GetAll();
        List<BusRoute> FindBusesTo(string location);
        BusRoute? FindByNumber(int routeNumber);
        int RemoveAllRoutesTo(string location);
    }
}
