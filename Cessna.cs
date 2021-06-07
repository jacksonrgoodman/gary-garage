using System;

namespace Garage
{
    public class Cessna : Vehicle// Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}