using BusRoutesApp.Entities;

namespace BusRoutesApp.Services
{
    public class BusStopService : IBusStopService
    {
        private BusStop _busStop;

        public BusStopService(string stopName)
        {
            _busStop = new BusStop(stopName);
        }

        public void PassengersArrive(int numberOfPassengers)
        {
            Console.WriteLine($"\r\n{numberOfPassengers} passengers arriving at {_busStop} bus stop");

            for (int i = 0; i < numberOfPassengers; i++)
                _busStop.PersonArrive(PassengerGenerator.CreatePassenger());
        }

        public void BusArrive(Bus bus)
        {
            _busStop.BusArrive(bus);
        }
    }
}
