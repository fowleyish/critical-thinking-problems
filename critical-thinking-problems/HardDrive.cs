using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    class HardDrive
    {
        // Member vars
        public double totalStorage;
        public double availableStorage;
        public List<Application> applications;

        // Constructor
        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
        }

        // Member methods
    }
}
