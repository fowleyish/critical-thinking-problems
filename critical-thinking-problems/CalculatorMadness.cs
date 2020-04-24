using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    class CalculatorMadness
    {

        // Methods

        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public void RunCalculations()
        {
            //Console.Write("Please enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the secpmd number: ");
            //int num2 = int.Parse(Console.ReadLine());
            int output = Add(Subtract(Add(6, 5), Divide(Multiply(40, 35), 4)), Multiply(2, 2));

            Console.WriteLine($"The result of this calculation is {output}");
        }
    }
}
