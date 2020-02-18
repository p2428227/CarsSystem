using System;

namespace CarsClasses
{
    public class clsOrder
    {
        public int CustomerId;

        public int OrderId { get; set; }
        public int StaffId { get; set; }
        public int vinNumber { get; set; }
        public string location { get; set; }
        public bool Finance { get; set; }
        public bool paymentStatus { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}