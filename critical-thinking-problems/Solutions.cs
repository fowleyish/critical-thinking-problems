using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace critical_thinking_problems
{
    class LoopSolutions
    {
        // Loop solutions are in this class





        public void ForLoopExample(int num)
        {
            string msg = "Hello World";
            //bool print = true;
            for (int i = 0; i < msg.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(msg[i]);
                    //print = false;
                }
                //else
                //{
                //    print = true;
                //}
            }
        }





        public void WhileLoopExample(int num)
        {
            Console.Write("Enter the number 42: ");
            int.TryParse(Console.ReadLine(), out num);

            while (num != 42)
            {
                WhileLoopExample(num);
            }

            if (num == 42)
            {
                Console.WriteLine("Great!");
            }
        }
    }
}
