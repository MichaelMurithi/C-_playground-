using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            var names = new string[]
            {
                "Sarah",
                "Amrit",
                "Gentry"
            };

            string? firstNameWithZIn =
                FindFirst<string>(names, name => name.Contains("z"));

            Console.Write(firstNameWithZIn?.Length);

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
