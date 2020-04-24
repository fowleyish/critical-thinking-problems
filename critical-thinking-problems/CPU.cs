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
        public void InstallApplication(TextEditor te, Game game, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (CheckRequirements(te, game, hardDrive, ram, gpu))
            {
                if (te == null)
                {
                    hardDrive.applications.Add(game);
                    hardDrive.ConsumeStorage(game.requiredStorage);
                }
                else
                {
                    hardDrive.applications.Add(te);
                    hardDrive.ConsumeStorage(te.requiredStorage);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough resources to install this applicaiton.");
            }
        }

        public bool CheckRequirements(TextEditor te, Game game, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (te != null)
            {
                if (ram.totalGigs >= te.requiredRAM && hardDrive.availableStorage >= te.requiredStorage)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (game != null)
            {
                if (ram.totalGigs >= game.requiredRAM && hardDrive.availableStorage >= game.requiredStorage && gpu.effectiveMemory >= game.requiredEffectiveMemory)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
