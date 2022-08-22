#nullable enable

using System;

namespace CSNullBasics
{
    class Program
    {
        static void Main()
        {
#nullable disable
            string message = null;
#nullable enable

            Console.WriteLine(message);

            Console.WriteLine("Press enter to end.");
            Console.ReadLine();
        }
    }
}
