namespace BusRoutesApp.Services
{
    public interface IBusRoutesService
    {
        void CleanUpRoutes();
        void FindBusRoute();
        void FindConnection();
        void FindRouteByNumber();
        void ShowBusTimes39();
    }
}