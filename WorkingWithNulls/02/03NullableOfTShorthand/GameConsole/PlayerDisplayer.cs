using System;

namespace GameConsole
{
    /// <summary>
    /// More on Nullable<T>
    /// * .HasValue - false if null, otherwise true
    /// * .Value - gets underlying value
    /// * .GetValueOrDefault() - underlying value or default
    /// </summary>
    static class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }
            else
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }

            if (player.DateOfBirth.HasValue)
            {
                Console.WriteLine(player.DateOfBirth);
            }
            else
            {
                Console.WriteLine("No date of birth specified");
            }
        }
    }
}
