namespace BusRoutesApp.Entities
{
    public class BusRoute
    {
        public int Number { get; }
        public string Origin => PlacesServed[0];
        public string Destination => PlacesServed[^1];
        public string[] PlacesServed { get; }

        public BusRoute(int number, string[] placesServed)
        {
            Number = number;
            PlacesServed = placesServed;
        }

        public override string ToString()
        {
            return $"{Number}: {Origin} -> {Destination}";
        }

        public bool Serves(string destination)
        {
            return Array.Exists(PlacesServed, (place) => place == destination);
        }
    }
}
