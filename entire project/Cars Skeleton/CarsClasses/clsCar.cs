using System;
namespace CarsClasses
{
    public class clsCar
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int VIN { get;  set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Colour { get; set; }
        public string Fuel { get; set; }
        public float MPG { get; set; }
        public int Age { get; set; }
        public int TopSpeed { get; set; }
    }
}