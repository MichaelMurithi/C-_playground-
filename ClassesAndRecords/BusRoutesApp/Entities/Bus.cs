namespace BusRoutesApp.Entities
{
    public class Bus
    {
        public int Capacity { get; init; }
        public int RouteNumber { get; init; }
        private LinkedList<Passenger> _passengers = new();
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
            
            _passengers.AddLast(passenger);
            Console.WriteLine($"{passenger} got on the bus");

            return true;
        }

        public void ArriveAt(string place)
        {
            Console.WriteLine($"\r\nBus {RouteNumber} arriving at {place} \n");
           
            if (_passengers.Count == 0)
                return;

            LinkedListNode<Passenger>? currentNode = _passengers.First;
            
            do
            {
                LinkedListNode<Passenger>? nextNode = currentNode?.Next;
               
                if(currentNode?.Value.Destination == place)
                {
                    Console.WriteLine($"{currentNode.Value} is getting off");
                    _passengers.Remove(currentNode);
                }
                
                currentNode = nextNode;

            } while(currentNode != null);

            Console.WriteLine($"\r\nThere are {_passengers.Count} passengers still on the bus");    
        }
    }
}
