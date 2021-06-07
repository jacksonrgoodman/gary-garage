using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}