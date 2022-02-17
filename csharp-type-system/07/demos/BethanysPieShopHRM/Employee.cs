using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    public class Employee
    {
        //public string firstName;
        //public string lastName;
        //public string email;

        //public int numberOfHoursWorked;
        //public double wage;
        //public double hourlyRate;

        //public DateTime birthDay;
        //EmployeeType employeeType;

        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;

        private DateTime birthDay;
        private EmployeeType employeeType;

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
        public double HourlyRate
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

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType, double rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            EmployeeType = empType;
            HourlyRate = rate;
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
            Wage = NumberOfHoursWorked * HourlyRate;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\nEmployee type: {EmployeeType}\n");
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
