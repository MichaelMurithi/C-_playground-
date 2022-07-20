namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();

            Console.ReadLine();
        }

        private static void StackStrings()
        {
            var stringStack = new SimpleStack<string>();
            
            stringStack.Push("Learning C# is really amaxzing");
            stringStack.Push("Yes, at some point it is really boring");
            stringStack.Push("All you need to do is");
            stringStack.Push("To enjoy creating objects and");
            stringStack.Push("Working with types and interfaces");

            while (stringStack.Count > 0) { 
                Console.WriteLine(stringStack.Pop());
            }
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            double sum = 0.0;

            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.5);

            while (stack.Count > 0)
            {

                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}
