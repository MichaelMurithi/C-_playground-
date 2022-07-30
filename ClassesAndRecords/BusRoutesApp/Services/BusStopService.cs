using BusRoutesApp.Entities;
using BusRoutesApp.Repositories;

namespace BusRoutesApp.Services
{
    public class BusStopService : IBusStopService
    {
        private BusStop _busStop;
        private PassengerGenerator _passengerGenerator;
        private IBusRouteRepository _routeRepository;

        public BusStopService(IBusRouteRepository busRouteRepository, string stopName)
        {

            _busStop = new BusStop(stopName);
            _routeRepository = busRouteRepository;
            var busRoute = _routeRepository.FindByNumber(39);
            _passengerGenerator = new PassengerGenerator(busRoute);
        }

        public void PassengersArrive(int numberOfPassengers)
        {
            Console.WriteLine($"\r\n{numberOfPassengers} passengers arriving at {_busStop} bus stop");

            for (int i = 0; i < numberOfPassengers; i++)
                _busStop.PersonArrive(_passengerGenerator.CreatePassenger());
        }

        public void BusArrive(Bus bus)
        {
            _busStop.BusArrive(bus);
        }
    }
}
