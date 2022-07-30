using BusRoutesApp.Entities;

namespace BusRoutesApp.Services
{
    public class PassengerGenerator
    {
        private static int _count = 0;

        public static Passenger CreatePassenger()
        {
            string destination = "Patronka";

            return new Passenger($"Person {++_count}", destination);
        }
    }
}
