using BusRoutesApp.Entities;
using BusRoutesApp.Repositories;
using BusRoutesApp.Services;

class Program
{
    static void Main(string[] args)
    {
        IBusRouteRepository routesRepository = new BusRouteRepository();
        IBusRoutesService busRoutesService = new BusRoutesService(routesRepository);

        busRoutesService.ShowBusTimes39();

        IBusStopService zooBusStop = new BusStopService("Zoo");
        Bus bus39 = new(39);

        zooBusStop.PassengersArrive(6);
        zooBusStop.BusArrive(bus39);

        bus39.ArriveAtTerminus();
    }

   
}
