using BusRoutesApp.Entities;

namespace BusRoutesApp.Services
{
    public class PassengerGenerator
    {
        private static int _count = 0;
        private static Random _random = new();
        private BusRoute _busRoute { get; init; }
        public PassengerGenerator(BusRoute busRoute)
        {
            _busRoute = busRoute;
        }
        public Passenger CreatePassenger()
        {
            int numberOfStops = _busRoute.PlacesServed.Length;
            string destination = _busRoute.PlacesServed[_random.Next(numberOfStops -1)];

            return new Passenger($"Person {++_count}", destination);
        }
    }
}
