using System;

namespace critical_thinking_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This program is built on some simple critical thinking problems.");

            //LoopSolutions loop = new LoopSolutions();
            //Console.Write("How many times would you like the for loop to run?: ");
            //int.TryParse(Console.ReadLine(), out int result);
            //solution.ForLoopExample(result);

            //Console.Write("Where would you like the while loop to start? (MAX=24): ");
            //int.TryParse(Console.ReadLine(), out int result);
            //solution.WhileLoopExample(result);
            //loop.WhileLoopExample(0);

            //CalculatorMadness calc = new CalculatorMadness();
            //calc.RunCalculations();

            Computer comp = new Computer();
            comp.InstallApps();
        }
    }
}
