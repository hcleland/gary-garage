using System;
namespace Garage
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        // public void RefuelTank() { ... }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbled by. ZOOOOOOOOM!");
        }
    }
}