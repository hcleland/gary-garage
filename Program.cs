using System;

namespace Garage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram bigTruck = new Ram();

            fxs.MainColor = "red";
            fxs.MaximumOccupancy = "4";

            modelS.MainColor = "grey";
            modelS.MaximumOccupancy = "5";

            mx410.MainColor = "white";
            mx410.MaximumOccupancy = "2";

            bigTruck.MainColor = "blue";
            bigTruck.MaximumOccupancy = "3";

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine(" ");

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine(" ");

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine(" ");

            bigTruck.Drive();
            bigTruck.Turn("left");
            bigTruck.Stop();
            Console.WriteLine(" ");
        }
    }
}
