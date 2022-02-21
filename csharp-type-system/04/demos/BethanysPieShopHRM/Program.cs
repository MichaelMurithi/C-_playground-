using System;
using System.Text;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Demo 1
            //string myPhrase = "Today I decided to learn the Csharp type system";
            //string emphasize = myPhrase.ToUpper();
            //string lower = myPhrase.ToLower();

            //bool iSeeSharp = myPhrase.Contains("Csharp");
            //string newPhrase = myPhrase.Replace("Csharp", "Python");
            //string timeOfLearning = newPhrase.Substring(0, 5);

            //Console.WriteLine($"{myPhrase}\njust to emphasize; {emphasize} and \nin case you did not get it; {lower}" +
            //    $"\nAsking if I learn Csharp? the answer is {iSeeSharp}.\nWant to know when I'm learning? {timeOfLearning}");

            ////Demo 2
            //string firstName = "Michael";
            //string lastName = "Murithi";

            //string fullName = string.Concat(firstName, " ", lastName);

            //string employeeId = firstName.ToLower() + "-" + lastName.ToLower();

            //int length = employeeId.Length;

            //if (fullName.ToLower().Contains("mich"))
            //{
            //    Console.WriteLine("\nHey! We finally found Michael!\n");
            //}

            //string substring = fullName.Substring(0, 4);
            //Console.WriteLine($"His fullname has {length} characters. The first 4 characters are {substring}");

            ////Demo 3
            //string displayName = $"Welcome!\n{firstName}\t{lastName}";
            //string invalidFilePath = "C:\data\employeelist.xlsx";
            //string filePath = "C:\\data\\employeelist.xlsx";
            //string marketingTagLine = "Baking the \"best pies\" ever";

            //string verbatimFilePath = @"C:\data\employeelist.xlsx"; // => disables escape sequences.

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
            //string name = "Bethany";
            //string anotherName = name;
            //name += " Smith";

            //Console.Write("Name: " + name);
            //Console.WriteLine("Another name: " + anotherName);

            //string lowerCaseName = name.ToLower();

            //string indexes = string.Empty;

            //for (int i = 0; i < 2500; i++)
            //{
            //    indexes += i.ToString();
            //}


            //string firstName = "Bethany";
            //string lastName = "Smith";

            //StringBuilder plans = new StringBuilder();
            //plans.AppendLine("..................................................................");
            //plans.AppendLine("\nMy Plans for 2022\n");
            //plans.AppendLine("Get Microsoft Azure Fundamentals certification");
            //plans.AppendLine("Learn C Programming language");
            //plans.AppendLine("Master C# .net");
            //plans.AppendLine("Get comfortable with Devops concepts (Kubernetes, Docker, deployment)");
            //plans.AppendLine("Complete my first year of university successfully");
            //string results = plans.ToString();
            //Console.WriteLine(results);

            ////Demo 6
            Console.WriteLine("Enter the wage:");
            string wage = Console.ReadLine();

            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine($"Passing a wage of {wageValue} successfull");
            else
                Console.WriteLine("Please provide a valid wage!");
        }
    }
}
