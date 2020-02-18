using System;

namespace UnitTestProject1
{
    internal class clsCar
    {
        public bool Active { get; internal set; }
        public string CarColour { get; internal set; }
        public string Mileage { get; internal set; }
        public int Price { get; internal set; }
        public int VIN { get; internal set; }
        public DateTime DateAdded { get; internal set; }
    }
}