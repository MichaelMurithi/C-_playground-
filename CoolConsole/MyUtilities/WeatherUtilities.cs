using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolConsole.MyUtilities
{
    internal class WeatherUtilities
    {
        public static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;

        }

        public static float CelsiusToFahrenheit(float temperatureCelcius)
        {
            return (temperatureCelcius * 1.8f) - 32;

        }

        // The higher the index, the lower the comfort

        static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            // Probably not a very reliable formula
            return (temperatureFahrenheit - humidityPercent) / 4;
        }

        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            Console.WriteLine($"Comfort index for {location} : {ComfortIndex(CelsiusToFahrenheit(temperatureCelsius), humidity)}");
        }
    }
}
