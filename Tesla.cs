using System;

namespace Garage
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("...");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla went cruising past. ZOOOOOOOOM!");
        }

        public override void Stop()
        {

            Console.WriteLine($"Did the {MainColor} Tesla stop? It's so quiet - I can't tell!");
        }
    }
}