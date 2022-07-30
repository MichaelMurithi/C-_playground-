namespace BusRoutesApp.Entities
{
    public class Bus
    {
        public int Capacity { get; init; }
        public int RouteNumber { get; init; }
        private Stack<Passenger> _passengers = new();
        public int Space {get =>Capacity - _passengers.Count;}

        public Bus(int routeNumber,int capacity = 5)
        {
            RouteNumber = routeNumber;
            Capacity = capacity;
        }

        public bool Load(Passenger passenger)
        {
            if(Space < 1)
                return false;
            
            _passengers.Push(passenger);
            Console.WriteLine($"{passenger} got on the bus");

            return true;
        }

        public void ArriveAtTerminus()
        {
            Console.WriteLine($"\r\nBus {RouteNumber} arriving at the terminus \n");
            
            while(_passengers.Count > 0)
            {
                Passenger passenger = _passengers.Pop();
                Console.WriteLine($"{passenger} got off the bus");
            }

            Console.WriteLine($"\r\nThere are {_passengers.Count} passengers still on the bus");    
        }
    }
}
