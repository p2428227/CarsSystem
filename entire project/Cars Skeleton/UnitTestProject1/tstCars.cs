using System;
using CarsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstCars
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
            int TestData = 1;
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
            int TestData = 56000;
            //assign the data to the property
            ACar.Mileage = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Mileage, TestData);
        }

        [TestMethod]
        public void ColourOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Green";
            //assign the data to the property
            ACar.Colour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Colour, TestData);
        }

        public void FuelOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Petrol";
            //assign the data to the property
            ACar.Fuel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Fuel, TestData);
        }

        public void MPGOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            double TestData = 37.5;
            //assign the data to the property
            ACar.MPG = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.MPG, TestData);
        }

        public void AgeOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            int TestData = 5;
            //assign the data to the property
            ACar.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Age, TestData);
        }

        public void TopSpeedOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            int TestData = 125;
            //assign the data to the property
            ACar.TopSpeed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.TopSpeed, TestData);
        }

        public void FindMethodOK()
        {
            //Creates an instance of Car
            clsCar ACar = new clsCar();
            //Boolean variable to hold the result of validation
            Boolean Found = false;
            //Create some test data
            Int32 VIN = 1;
            //Invoke the find method
            Found = ACar.Find(VIN);
            //Test to see if the result is correct
            Assert.IsTrue(Found);
        }

        public void TestCarNoFound()
        {
            //hope this works
            clsCar ACar = new clsCar();
            Boolean Found = false;
            Boolean OK = true;
            Int32 VINNumber = 1;
            Found = ACar.Find(VINNumber);
            if (ACar.VIN != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);



        }

    }
}

