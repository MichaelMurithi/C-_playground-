using System;

namespace CSNullBasics
{
    class Program
    {
        static void Main()
        {
#nullable enable
            string message = null;
#nullable disable

            Console.WriteLine(message);

            Console.WriteLine("Press enter to end.");
            Console.ReadLine();
        }
    }
}
