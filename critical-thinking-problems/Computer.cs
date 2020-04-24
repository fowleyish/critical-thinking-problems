using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    class Computer
    {
        // Member vars
        Motherboard mb;
        CPU cpu;
        GPU gpu;
        HardDrive hdd;
        RAM ram;

        // Constructor
        public Computer()
        {
            cpu = new CPU("Intel", "i7 6th gen");
            gpu = new GPU("Radeon", 16);
            hdd = new HardDrive(1000, 988);
            ram = new RAM(16, "Some cool brand you've never heard of");
            mb = new Motherboard("ASUS", ram, cpu, hdd, gpu);
        }

        // Member methods
        public void InstallApps()
        {
            while (true)
            {
                Console.WriteLine("Would you like to install a new application on your computer? Enter 1 for yes or anything else to stop.");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    string appType = GetApp();
                    if (appType == "game")
                    {
                        Console.Write("How much GPU memory does the game require to run?: ");
                        double gpuReq = double.Parse(Console.ReadLine());
                        Game app = new Game(gpuReq);
                        cpu.InstallApplication(null, app, hdd, ram, gpu);
                    }
                    else if (appType == "te")
                    {
                        TextEditor app = new TextEditor();
                        cpu.InstallApplication(app, null, hdd, ram, gpu);
                    }
                }
                else
                {
                    Console.WriteLine("Your computer is all set up!");
                    break;
                }
            }
        }

        public string GetApp()
        {
            Console.WriteLine("Are you trying to install a Text Editor (1) or a Game (2)? \n" +
                "Enter the corresponding number or anything else to cancel.");
            string response = Console.ReadLine();
            if (response == "1")
            {
                return "te";
            }
            else if (response == "2")
            {
                return "game";
            }
            else
            {
                return null;
            }
        }
    }
}
