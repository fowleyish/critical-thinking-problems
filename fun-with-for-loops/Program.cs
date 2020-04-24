using System;

namespace fun_with_for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions solution = new Solutions();
            Console.Write("How many times would you like the loop to run?: ");
            int.TryParse(Console.ReadLine(), out int result);
            solution.ForLoopExample1(result);
        }
    }
}
