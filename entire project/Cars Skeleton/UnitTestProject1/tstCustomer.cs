using System;
using CarsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstantOk()
        {
            //create an instance of the class we wnat to create
            clsCustomer AnCustomer = new clsCustomer();

            //test to see if it exists 
            Assert.IsNotNull(AnCustomer);
        }
    }
}
