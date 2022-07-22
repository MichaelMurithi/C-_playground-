using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employeeRepository);
            AddManagers(employeeRepository);
            WriteAllToConsole(employeeRepository);
            GetEmployeeById(employeeRepository);


            var organizationRepository = new ListRepository<Organization>();
            AddOrganizations(organizationRepository);
            WriteAllToConsole(organizationRepository);
        }

        private static void AddManagers(IWriteRepository<Manager> managerRepository)
        {
            managerRepository.Add(new Manager { FirstName = "Matej" });
            managerRepository.Add(new Manager { FirstName = "Marek" });

            managerRepository.Save();
        }

        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            Console.WriteLine("\nEmployee by Id 1:\n");

            var employee = employeeRepository.GetById(1);
            Console.WriteLine(employee.ToString());
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            Console.WriteLine("\nEmployees:\n");

            employeeRepository.Add(new Employee { FirstName = "Polycarp" });
            employeeRepository.Add(new Employee { FirstName = "Peterson" });
            employeeRepository.Add(new Employee { FirstName = "Rodgers" });
            employeeRepository.Add(new Employee { FirstName = "Duncan" });
            employeeRepository.Add(new Employee { FirstName = "Shirly" });

            employeeRepository.Save();
        }

        private static void AddOrganizations(IRepository<Organization> organizationRepository)
        {
            Console.WriteLine("\nOrganizations:\n");

            organizationRepository.Add(new Organization { Name = "Telemetrics" });
            organizationRepository.Add(new Organization { Name = "Amazon" });
            organizationRepository.Add(new Organization { Name = "Commenius" });
            organizationRepository.Add(new Organization { Name = "Ruzinovska" });
            organizationRepository.Add(new Organization { Name = "Financier" });

            organizationRepository.Save();
        }

        private static void WriteAllToConsole(IReadRepository<IEntity> repository)
        {
            var items = repository.GetAll();

            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
