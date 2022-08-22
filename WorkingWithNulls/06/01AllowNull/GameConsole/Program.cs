using System;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter?[] players = 
            {
                new PlayerCharacter("Sarah"),
                new PlayerCharacter("Gentry"),
                null
            };


            PlayerDisplayer.Write(players[0]);
            PlayerDisplayer.Write(players[1]);
            PlayerDisplayer.Write(players[2]);

            Console.ReadLine();
        }
    }
}
