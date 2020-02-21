using System;

namespace UnitTestProject1
{
    internal class clsCar
    {

        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public String VIN { get; internal set; }
        public int Price { get; internal set; }
        public int Mileage { get; internal set; }
        public string Colour { get; internal set; }
        public string Fuel { get; internal set; }
        public float MPG { get; internal set; }
        public int Age { get; internal set; }
        public int TopSpeed { get; internal set; }
    }
}