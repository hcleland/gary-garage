using System;

namespace Garage
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        // public void RefuelTank() { ... }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flew over. ZOOOOOOOOM!");
        }

        public override void Stop()
        {

            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}