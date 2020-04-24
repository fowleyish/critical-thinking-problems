using System;

namespace critical_thinking_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This program is built on some simple critical thinking problems.");

            Solutions solution = new Solutions();
            Console.Write("How many times would you like the loop to run?: ");
            int.TryParse(Console.ReadLine(), out int result);
            solution.ForLoopExample(result);
        }
    }
}
