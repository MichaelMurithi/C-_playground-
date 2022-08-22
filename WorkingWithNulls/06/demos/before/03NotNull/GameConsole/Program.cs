using System;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter p1 = new();

            p1.Name = null;
            p1.Bio = null;

            Console.ReadLine();
        }
    }
}
