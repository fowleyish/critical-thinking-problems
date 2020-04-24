using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace critical_thinking_problems
{
    class Solutions
    {
        // All solutions are in this class





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





        public void WhileLoopExample()
        {

        }
    }
}
