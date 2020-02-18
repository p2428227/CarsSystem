using System;
using CarsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists
            Assert.IsNotNull(AnOrder);
        }

    }
}
