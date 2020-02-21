using System;

namespace CarsClasses
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime dateAdded { get; set; }
        public int customerID { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public long mobileNumber { get; set; }
        public string address { get; set; }
        public bool loyaltyDiscount { get; set; }
    }
}