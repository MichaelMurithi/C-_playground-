﻿namespace BusRoutesApp.Entities
{
    public class BusTimes
    {
        public string[][] Times { get; }
        public BusRoute Route { get; }
        public BusTimes(BusRoute route, string[][] times)
        {
            Route = route;
            Times = times;
        }
    }
}
