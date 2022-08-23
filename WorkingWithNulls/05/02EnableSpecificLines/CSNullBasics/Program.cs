using System;

namespace CSNullBasics
{
    class Program
    {
        static void Main()
        {
            #nullable disable
            string message = null;
            Console.WriteLine(message);
            #nullable enable
            Console.WriteLine("Press enter to end.");
            Console.ReadLine();
        }
    }
}
