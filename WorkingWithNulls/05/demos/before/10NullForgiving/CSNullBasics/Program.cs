using System;

namespace CSNullBasics
{
    class Program
    {
        static void Main()
        {

            Message message = new() 
            {
                Text = "Hello there!",
                From = null
            };


            Console.WriteLine(message.Text);
            Console.WriteLine(message.From ?? "no from");
            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press enter to end.");
            Console.ReadLine();
        }
    }
}
