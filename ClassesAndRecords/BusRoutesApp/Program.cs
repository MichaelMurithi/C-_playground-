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
    }

   
}
