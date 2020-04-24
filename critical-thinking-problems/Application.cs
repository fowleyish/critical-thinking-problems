using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    abstract class Application
    {
        // Member vars
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;

        // Constructor
        public Application()
        {
            applicationName = GetAppName();
            applicationType = GetAppType();
            requiredRAM = GetRequiredRAM();
            requiredStorage = GetRequiredStorage();
        }

        // Member methods
        public string GetAppName()
        {
            Console.Write("What is the name of the application?: ");
            return Console.ReadLine();
        }

        public string GetAppType()
        {
            Console.Write("What type of application is this?: ");
            return Console.ReadLine();
        }

        public double GetRequiredRAM()
        {
            Console.Write("How much RAM does it require?: ");
            return double.Parse(Console.ReadLine());
        }

        public double GetRequiredStorage()
        {
            Console.Write("How much storage does it require?: ");
            return double.Parse(Console.ReadLine());
        }

    }
}
