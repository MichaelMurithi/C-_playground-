using CoolConsole.MyUtilities;
using System;

namespace Cool
{
    public static class CheckComfort
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Where should we go for a vacation?");
            WeatherUtilities.Report("Mombasa", WeatherUtilities.FahrenheitToCelsius(70), 20);
            WeatherUtilities.Report("Bratislava", 23, 65);
        }
    }
}