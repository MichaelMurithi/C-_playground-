using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            string badParse = "Name-Amrit"; // - instead of :
            string goodParse = "Name:Amrit";

            if (PlayerCharacter.TryParse(badParse, out var p1))
            {
                Console.WriteLine(p1.Name);
            }
            else
            {
                Console.WriteLine($"could not parse {badParse}");
            }

            if (PlayerCharacter.TryParse(goodParse, out var p2))
            {
                Console.WriteLine(p2.Name);
            }

            Console.ReadLine();
        }

        static void ExitProgramIfNull([NotNull]string? input,
                                      string inputDescription)
        {
            if (input is null)
            {
                Console.WriteLine($"{inputDescription} was null, exiting program.");

                Console.ReadLine();

                Environment.Exit(-1);
            }
        }

        static T? FindFirst<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (T item in items)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }
    }
}
