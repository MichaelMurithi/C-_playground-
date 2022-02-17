using System;
using System.Globalization;
using System.Text;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Demo 1
            //string firstName = "Bethany";
            //string lastName = "Smith";
            //System.String fullName = "Bethany Smith";
            //string noValueString = null;
            //string s;
            //s = firstName;
            //var userName = "BethanyS";

            ////Demo 2
            //string fullName = firstName + " " + lastName;
            //string employeeIdentification = String.Concat(firstName, lastName);
            ////string empId = firstName.ToLower() + "-" + firstName.ToLower();
            //string empId = firstName.ToLower() + "-" + firstName.Trim().ToLower();
            //int length = empId.Length;
            //if (fullName.Contains("beth") || fullName.Contains("Beth"))
            //{
            //    Console.WriteLine("It's Bethany!");
            //}
            //string subString = fullName.Substring(1, 3);
            //Console.WriteLine("Chararters 2 to 4 of fullName are " + subString);

            ////string interpolation
            //string nameUsingInterpolation = $"{firstName}-{lastName}";
            //string v = $"Hello, {firstName}!";

            ////Demo 3
            //string displayName = $"Welcome!\n{firstName}\t{lastName};
            //string invalidFilePath = "C:\data\employeelist.xlsx";
            //string filePath = "C:\\data\\employeelist.xlsx";
            //string marketingTagLine = "Baking the \"best pies\" ever";

            //string verbatimFilePath = @"C:\data\employeelist.xlsx";

            //Demo 4
            //string name1 = "Bethany";
            //string name2 = "BETHANY";

            //Console.WriteLine("Are both names equal? " + (name1 == name2));
            //Console.WriteLine("Is name equal to Bethany? " + (name1 == "Bethany"));
            //Console.WriteLine("Is name equal to BETHANY? " + name2.Equals("BETHANY"));
            //Console.WriteLine("Is uppercase name equal to bethany? " + (name1.ToLower() == "bethany"));

            //string name3 = name1;
            //name3 += " Smith";
            //Console.Write("Name1: " + name1);
            //Console.Write("Name3: " + name3);

            //Demo 5
            string name = "Bethany";
            string anotherName = name;
            name += " Smith";

            Console.Write("Name: " + name);
            Console.WriteLine("Another name: " + anotherName);

            string lowerCaseName = name.ToLower();

            string indexes = string.Empty;

            for (int i = 0; i < 2500; i++)
            {
                indexes += i.ToString();
            }


            string firstName = "Bethany";
            string lastName = "Smith";

            StringBuilder builder = new StringBuilder();
            builder.Append("Last name: ");
            builder.Append(lastName);
            builder.Append("First name: ");
            builder.Append(firstName);
            string result = builder.ToString();

            StringBuilder builder2 = new StringBuilder();

            for (int i = 0; i < 2500; i++)
            {
                builder2.Append(i);
                builder2.Append(" ");
            }
            string list = builder2.ToString();

            //Demo 6
            string wage = "1,234.15";
            //double wageValue = double.Parse(wage);
            
            //might actually fail because of cultural settings
            CultureInfo culture = null;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            double wageValueWithCulture = double.Parse(wage, culture);

            double wageValue;
            if (double.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing success: " + wageValue);
            else
                Console.WriteLine("Parsing failed");

            string hireDateString = "12/12/2020";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);
            //TryParse also exists for dates

            var cultureInfo = new CultureInfo("nl-BE");
            string birthDateString = "28 Maart 1984";//Dutch, spoken in Belgium
            var birthDate = DateTime.Parse(birthDateString, cultureInfo);
            Console.WriteLine("Birth date: " + birthDate);
        }
    }
}
