using System;

namespace Garage
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}