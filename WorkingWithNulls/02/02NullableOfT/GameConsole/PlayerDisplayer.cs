using System;

namespace GameConsole
{
    static class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin is null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBirth is null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNew is null)
            {
                Console.WriteLine("We don't know whether the player is new");
            }
            else if (player.IsNew is true)
            {
                Console.WriteLine("Player is new to the game");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
