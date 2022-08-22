using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace GameConsole
{
    class Program
    {
        static void Main()
        {
            var names = Array.Empty<string>();

            if (TryGetFirst<string>(names, out var foundName))
            {
                Console.Write(foundName.Length);
            }
            else
            {
                Console.Write($"Not found {foundName.Length}");
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

        static bool TryGetFirst<T>(IEnumerable<T> items,
                                   [MaybeNullWhen(false)] out T foundItem)
        {
            if (items.Any())
            {
                foundItem = items.First();
                return true;
            }

            foundItem = default;
            return false;
        }
    }
}
