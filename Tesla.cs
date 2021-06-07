using System;

namespace Garage
{
    public class Tesla : ElectricVehicle
    {


        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            //base.Drive();
            Console.WriteLine($"I drive a {MainColor} {Make}{Model} with an occupancy of {MaximumOccupancy}");
        }
    }
}