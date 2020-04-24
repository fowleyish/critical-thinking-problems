using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    class Motherboard
    {
        // Member vars
        public string manufacturer;
        public CPU processor;
        public RAM tempMemory;
        public HardDrive storage;
        public GPU graphics;

        // Constructor
        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            this.manufacturer = manufacturer;
            this.tempMemory = ram;
            this.processor = cpu;
            this.storage = hardDrive;
            this.graphics = gpu;
        }

        // Member methods
        
    }
}
