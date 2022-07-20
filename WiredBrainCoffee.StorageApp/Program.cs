using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddEmployees();
            AddOrganizations();
        }

        private static void AddEmployees()
        {
            Console.WriteLine("\nEmployees:\n");

            var employeeRepository = new GenericRepository<Employee>();

            employeeRepository.Add(new Employee { FirstName = "Polycarp", Id = 1 });
            employeeRepository.Add(new Employee { FirstName = "Peterson", Id = 2 });
            employeeRepository.Add(new Employee { FirstName = "Rodgers", Id = 3 });
            employeeRepository.Add(new Employee { FirstName = "Duncan", Id = 4 });
            employeeRepository.Add(new Employee { FirstName = "Shirly", Id = 5 });

            employeeRepository.Save();
        }

        private static void AddOrganizations()
        {
            Console.WriteLine("\nOrganizations:\n");

            var employeeRepository = new GenericRepository<Organization>();

            employeeRepository.Add(new Organization { Name = "Telemetrics", Id = 1 });
            employeeRepository.Add(new Organization { Name = "Amazon", Id = 2 });
            employeeRepository.Add(new Organization { Name = "Commenius", Id = 3 });
            employeeRepository.Add(new Organization { Name = "Ruzinovska", Id = 4 });
            employeeRepository.Add(new Organization { Name = "Financier", Id = 5 });

            employeeRepository.Save();
        }
    }
}
