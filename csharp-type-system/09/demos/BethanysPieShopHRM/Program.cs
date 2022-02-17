using BethanysPieShopHRM.HR;
using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            //Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            //JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            //Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            //Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            Employee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            Employee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            Employee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

            mary.DisplayEmployeeDetails();
            mary.PerformWork();
            mary.PerformWork();
            mary.PerformWork();
            mary.AttendManagementMeeting();
            mary.ReceiveWage();

            bobJunior.ResearchNewPieTastes(5);
            bobJunior.ReceiveWage();

            Employee[] employees = new Employee[5];
            employees[0] = bethany;
            employees[1] = mary;
            employees[2] = bobJunior;
            employees[3] = kevin;
            employees[4] = kate;

            foreach (var employee in employees)
            {
                employee.PerformWork();
                employee.ReceiveWage();
                employee.DisplayEmployeeDetails();
                employee.GiveBonus();
                //employee.AttendManagementMeeting();
            }

            Console.ReadLine();
        }
    }
}
