using System;

namespace CSNullBasics
{
    class Program
    {
        static void Main()
        {
            Message message = new()
            {
                Text = "Hello world",
                From =  null
            };

            Console.WriteLine($"From: {message.From ?? "no from"}");
            Console.WriteLine($"\tText: {message.Text}");
            Console.WriteLine($"Sender: {message.ToUpperFrom()}");

            Console.WriteLine("\nPress enter to end.");
            Console.ReadLine();
        }
    }
}
