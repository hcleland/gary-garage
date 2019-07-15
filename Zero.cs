using System;
namespace Garage
{

    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} fxs silenty crept behind us. SSSHHHH!");
        }
    }
}