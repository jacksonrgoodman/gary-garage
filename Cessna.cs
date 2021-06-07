using System;

namespace Garage
{
    public class Cessna : Vehicle// Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
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