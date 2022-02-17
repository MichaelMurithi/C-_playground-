using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {

            //UsingEnumerations();

            //UsingACustomType();

            UsingAStruct();

            Console.ReadLine();
        }

        private static void UsingACustomType()
        {
            List<string> myStrings = new List<string>();

            string json = JsonConvert.SerializeObject(myStrings);
        }

        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;

            int baseWage = 1000;
            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculatedWage = 0;
            Console.WriteLine($"Employee type: {employeeType}");
            Console.WriteLine($"Store type: {storeType}");

            if (employeeType == EmployeeType.Manager)
            {
                calculatedWage = baseWage * 3;
            }
            else
            {
                calculatedWage *= 2;
            }

            if (storeType == StoreType.FullPieRestaurant)//Larger retail point so give a bonus
                calculatedWage += 500;


            Console.WriteLine($"The calculated wage is {calculatedWage}");
        }

        private static void UsingAStruct()
        {
            Employee employee;
            employee.Wage = 1250;
            employee.Name = "Bethany";
            employee.Work();
        }
    }

    struct Employee
    {
        public int Wage;
        public string Name;

        public void Work()
        {
            Console.WriteLine($"{Name} is now doing work!");
        }
    }

    enum EmployeeType
    {
        Sales,
        Manager,
        Research,
        StoreManager
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaurant = 100,
        Undefined = 99
    }
}
