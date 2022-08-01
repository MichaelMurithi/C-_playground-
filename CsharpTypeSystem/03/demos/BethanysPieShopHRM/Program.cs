using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //int monthlyWage = 1234;
            //int months = 12;
            //int bonus = 1000;

            //bool isActive = true;
            //double rating = 99.25;
            ////byte numberOfEmployees = 300;

            ////monthlyWage = true;

            //double ratePerHour = 12.34;
            //int numberOfHoursWorked = 165;
            //double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

            //ratePerHour += 3;
            //Console.WriteLine(ratePerHour);

            //if (currentMonthWage > 2000)
            //    Console.WriteLine("Top paid employee");

            //Console.WriteLine(currentMonthWage);

            ////one employee quits
            //int numberOfEmployees = 15;
            //numberOfEmployees--;
            //Console.WriteLine(numberOfEmployees);

            ////default values
            //bool a;
            //int b;

            //int intMaxValue = int.MaxValue;
            //int sameIntMaxValue = Int32.MaxValue;

            //char userSelection = 'a';
            //char upperVersion = char.ToUpper(userSelection);
            //bool isDigit = char.IsDigit(userSelection);
            //bool isLetter = char.IsLetter(userSelection);

            //DateTime hireDate = new DateTime(2012, 3, 28, 14, 30, 0);
            //Console.WriteLine(hireDate);
            //DateTime exitDate = new DateTime(2021, 12, 11);
            ////DateTime invalidDate = new DateTime(2021, 15, 11);
            //

            DateTime startDate = new DateTime(2022, 02, 1);
            DateTime endMonth = startDate.AddDays(27);
            DateTime today = DateTime.Today;

            DayOfWeek whenIsToday = today.DayOfWeek;
            bool isDST = startDate.IsDaylightSavingTime();

            Console.WriteLine($"The month starts on {startDate.ToShortDateString()} and ends on {endMonth.ToShortDateString()} \n" +
                $"Today is date {today.ToString()} on {whenIsToday.ToString()} \n");

            //Working with timespans:
            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(2,8, 35, 0);
            DateTime endHour = startHour.Add(workTime);

            Console.WriteLine($"The employee started working on {startHour.ToLongDateString()} and ended working on {endHour.ToShortDateString()}");

            //Changing within types:
            //1. Implicit conversion:
            int a = 1234;
            long l = a;


            //DateTime startDate = hireDate.AddDays(15);
            //Console.WriteLine(startDate);
            //var currentDate = DateTime.Now;
            //bool areWeInDst = currentDate.IsDaylightSavingTime();

            //DateTime startHour = DateTime.Now;
            //TimeSpan workTime = new TimeSpan(8, 35, 0);
            //DateTime endHour = startHour.Add(workTime);


            //Console.WriteLine(startHour);
            //Console.WriteLine(endHour);

            //Console.WriteLine(startHour.ToLongDateString());
            //Console.WriteLine(endHour.ToShortTimeString());


            //long veryLongMonth = numberOfHoursWorked;//works fine!

            //double d = 123456789.0;
            //int x= (int)d;

            //int intVeryLongMonth = (int) veryLongMonth;//might fail

            //short thisShortWontWork = (short)intMaxValue;

            //var monthlyWage = 1234;
            //var months = 12;
            //var bonus = 1000;

            //var isActive = true;
            //var rating = 99.25;
            //byte numberOfEmployees = 300;
            //var numberOfEmployees = 300;

            //monthlyWage = true;

            //var ratePerHour = 12.34;
            //int numberOfHoursWorked = 165;
            //var currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

            //ratePerHour += 3;
            //Console.WriteLine(ratePerHour);

            //Console.ReadLine();
        }
    }
}
