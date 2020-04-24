using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    class Solutions
    {
        // All solutions are in this class
        public void ForLoopExample1(int num)
        {
            string msg = "Hello World";
            for (int i = 0; i < msg.Length; i++)
            {
                Console.WriteLine(msg[i]);
            }
        }
    }
}
