using System;

namespace CarsClasses
{
    public class clsStaff
    {
        public int staffNumber { get; set; }
        public string fullName { get; set; }
        public string emailAddress { get; set; }
        public float hours { get; set; }
        public DateTime joinDate { get; set; }
        public int bankAccountNumber { get; set; }
        public bool staffDiscount { get; set; }
        public bool Active { get; set; }
    }
}