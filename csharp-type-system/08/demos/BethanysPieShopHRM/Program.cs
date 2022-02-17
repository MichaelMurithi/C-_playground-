using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, 25);
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, null);
            Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), EmployeeType.Research, 30);


            //Employee mysteryPerson = null;
            //mysteryPerson.DisplayEmployeeDetails();

            Customer customer = new Customer();

            #region First run Bethany

            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();
            bethany.DisplayEmployeeDetails();

            #endregion


            #region First run George

            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();
            george.DisplayEmployeeDetails();

            #endregion

            Employee.taxRate = 0.02;//woohoo, less money to pay
            #region Second run Bethany

            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();
            bethany.DisplayEmployeeDetails();

            #endregion

            #region Second run George

            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();
            george.DisplayEmployeeDetails();

            #endregion


            Employee.DisplayTaxRate();
            //List<Employee> employees = new List<Employee>();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1979, 1, 16), EmployeeType.StoreManager, null);
            //    employees.Add(randomEmployee);
            //}

            //employees.Clear();
            //employees = null;

            //GC.Collect();

            Console.ReadLine();
        }
    }
}
