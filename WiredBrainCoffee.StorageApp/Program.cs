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

            var employees = new[]
            {
                new Employee { FirstName = "Polycarp" },
                new Employee { FirstName = "Peterson" },
                new Employee { FirstName = "Rodgers" },
                new Employee { FirstName = "Duncan" },
                new Employee { FirstName = "Shirly" }
            };

            AddBatch(employeeRepository, employees);
        }

        private static void AddOrganizations(IRepository<Organization> organizationRepository)
        {
            Console.WriteLine("\nOrganizations:\n");

            var organizations = new[]
            {
                new Organization { Name = "Telemetrics" },
                new Organization { Name = "Amazon" },
                new Organization { Name = "Commenius" },
                new Organization { Name = "Ruzinovska" },
                new Organization { Name = "Financier" }
            };

            AddBatch(organizationRepository, organizations);
        }

        private static void AddBatch<T>(IRepository<T> repository, T[] entities) where T: IEntity
        {
            foreach(var entity in entities)
            {
                repository.Add(entity);
            }

            repository.Save();
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
