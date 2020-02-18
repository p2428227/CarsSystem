using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CarsTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //test to see that it exists
            Assert.IsNotNull(ACar);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACar.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACar.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.DateAdded, TestData);
        }


        [TestMethod]
        public void VINOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACar.VIN = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.VIN, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACar.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Price, TestData);
        }

        [TestMethod]
        public void Mileage()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            ACar.Mileage = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Mileage, TestData);
        }

        [TestMethod]
        public void CarColourOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            ACar.CarColour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarColour, TestData);
        }
    }
}
