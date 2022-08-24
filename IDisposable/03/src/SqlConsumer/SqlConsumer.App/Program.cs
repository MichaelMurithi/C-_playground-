using Microsoft.Extensions.Configuration;
using System;

namespace SqlConsumer.App
{
    class Program
    {
        private static DatabaseState _DatabaseState;
        private static IConfiguration _Config;
        
        static void Main(string[] args)
        {
            _Config = new ConfigurationBuilder()
                 .AddJsonFile("appSettings.json")
                 .Build();

            Console.WriteLine("'g' to Get Date; 'gc' to Garbage Collect; 'x' to Exit");
            var command = "";
            while (command != "x")
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "g":
                        GetDate();
                        break;

                    case "gc":
                        GC.Collect(2, GCCollectionMode.Forced, blocking: true, compacting: true);
                        Console.WriteLine("GC done");
                        break;
                }
            }
        }

        private static void GetDate()
        {
            /*
            if (_DatabaseState == null)
            {
                _DatabaseState = new DatabaseState(_Config);
            }
            Console.WriteLine(_DatabaseState.GetDate());
            */

            using (var s = new UnmanagedDatabaseState(_Config))
            {
                Console.WriteLine(s.GetDate());
            }
        }
    }
}
