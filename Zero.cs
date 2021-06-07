using System;

namespace Garage
{
    public class Zero : ElectricVehicle // Electric motorcycle
    {
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            //base.Drive();
            Console.WriteLine($"I drive a {MainColor} {Make} {Model} with an occupancy of {MaximumOccupancy}");
        }
    }
}