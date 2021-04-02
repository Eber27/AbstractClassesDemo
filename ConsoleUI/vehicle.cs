using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class vehicle
    {
        public int Year { get; set; } = 2014;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
