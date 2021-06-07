using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                Make = "Tazzari",
                Model = "Zero",
                MainColor = "Red",
                MaximumOccupancy = 2,
                BatteryKWh = 103.0
            };
            Tesla modelS = new Tesla()
            {
                Make = "Tesla",
                Model = "Model S",
                MainColor = "Blue",
                MaximumOccupancy = 7,
                BatteryKWh = 100.0
            };
            Cessna mx410 = new Cessna()
            {
                Make = "Cessna",
                Model = "MX410",
                MainColor = "White",
                MaximumOccupancy = 8,
                FuelCapacity = 206.0
            };
            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}
