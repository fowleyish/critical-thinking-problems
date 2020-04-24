using System;
using System.Collections.Generic;
using System.Text;

namespace critical_thinking_problems
{
    class CPU
    {
        // Member vars
        public string manufacturer;
        public string name;

        // Constructor
        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }

        // Member methods
        public void InstallApplication(TextEditor te, HardDrive hardDrive, RAM ram, Game game)
        {
            if (CheckRequirements(te, hardDrive, ram, game))
            {
                if (te == null)
                {
                    hardDrive.applications.Add(game);
                }
                else if (game == null)
                {
                    hardDrive.applications.Add(te);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough resources to install this applicaiton.");
            }
        }

        public bool CheckRequirements(TextEditor te, HardDrive hardDrive, RAM ram, Game game)
        {
            if (te == null) 
            {
                if (ram.totalGigs >= app.requiredRAM && hardDrive.availableStorage >= app.requiredStorage)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (game == null)
            {
                if (ram.totalGigs >= app.requiredRAM && hardDrive.availableStorage >= app.requiredStorage)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }


            if (ram.totalGigs >= app.requiredRAM && hardDrive.availableStorage >= app.requiredStorage)
            {
                if (game == null)
                {
                    return true;
                }
                else if (te == null)
                {
                    if ()
                }
            }
        }
    }
}
