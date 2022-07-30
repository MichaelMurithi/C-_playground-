namespace BusRoutesApp.Entities
{
    public class BusStop
    {
        private Queue<Passenger> _peopleWaiting = new();
        private string _location;

        public BusStop(string location)
        {
            _location = location;
        }

        public override string ToString() => _location;

        public void PersonArrive(Passenger passenger)
        {
            _peopleWaiting.Enqueue(passenger);
        }

        public void BusArrive(Bus bus)
        {
            Console.WriteLine($"\r\nBus number {bus.RouteNumber} arriving at bus stop to load passengers \n");
            
            while(bus.Space > 0 && _peopleWaiting.Count > 0)
            {
                Passenger passenger = _peopleWaiting.Dequeue();
                bus.Load(passenger);
            }
        }
    }
}
