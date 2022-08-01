using System;

namespace BethanysPieShopHRM.HR
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;
        public static double taxRate = 0.15;

        private DateTime birthDay;
        private EmployeeType employeeType;

        private const double maxAmountHoursWorked = 1000;//

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            set
            {
                numberOfHoursWorked = value;
            }
        }
        public double Wage
        {
            get { return wage; }
            set
            {
                wage = value;
            }
        }
        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                hourlyRate = value;
            }
        }
        public DateTime BirthDay
        {
            get { return birthDay; }
            set
            {
                birthDay = value;
            }
        }
        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set
            {
                employeeType = value;
            }
        }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType, double? rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            EmployeeType = empType;
            HourlyRate = rate ?? 10;
            //maxAmountHoursWorked = 100;//not allowed
        }

        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\nEmployee type: {EmployeeType}\nTax rate: {taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }
    }

    public enum EmployeeType
    {
        Sales,
        Manager,
        Research,
        StoreManager
    }
}
