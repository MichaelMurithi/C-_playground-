using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;


namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeAddedCallback = new itemAdded<Employee>(EmployeeAdded);

            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext(), employeeAddedCallback);
            AddEmployees(employeeRepository);
            AddManagers(employeeRepository);
            WriteAllToConsole(employeeRepository);
            GetEmployeeById(employeeRepository);


            var organizationRepository = new ListRepository<Organization>();
            AddOrganizations(organizationRepository);
            WriteAllToConsole(organizationRepository);
        }

        private static void EmployeeAdded(Employee employee)
        {
            Console.WriteLine($"Employee {employee.FirstName} addded");
        }

        private static void AddManagers(IWriteRepository<Manager> managerRepository)
        {
            var lineManager = new Manager { FirstName = "Matej" };
            var lineManagerCopy = lineManager.Copy();

            if (lineManagerCopy != null)
            {
                lineManagerCopy.FirstName += "_Copy";
                managerRepository.Add(lineManagerCopy);
            }

            managerRepository.Add(lineManager);
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

            employeeRepository.AddBatch(employees);
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

            organizationRepository.AddBatch(organizations);
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
