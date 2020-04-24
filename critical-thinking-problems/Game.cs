using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    class Game : Application
    {
        // Member vars
        public double requiredEffectiveMemory;

        // Constructor
        public Game(double gpuMem)
        {
            requiredEffectiveMemory = gpuMem;
        }

        // Member methods
    }
}
