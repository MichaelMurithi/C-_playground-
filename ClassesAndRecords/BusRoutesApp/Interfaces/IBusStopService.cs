using BusRoutesApp.Entities;

namespace BusRoutesApp.Services
{
    public interface IBusStopService
    {
        void BusArrive(Bus bus);
        void PassengersArrive(int numberOfPassengers);
    }
}
