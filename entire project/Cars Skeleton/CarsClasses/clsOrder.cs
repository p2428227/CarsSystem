using System;

namespace CarsClasses
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public int VinNumber { get; set; }
        public string Location { get; set; }
        public bool Finance { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
    }
}