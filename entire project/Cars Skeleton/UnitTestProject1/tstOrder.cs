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
        [TestMethod]
        public void ActivePropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //check if ID exists
            clsOrder AnOrder = new clsOrder();
            //test to see if ID is entered
            //create test data
            int TestData = 1;
            //assign data to property
            AnOrder.OrderId = TestData;
            //test that the values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //check if Customer ID exists
            clsOrder AnOrder = new clsOrder();
            //test to see if ID is entered
            //create test data
            int TestData = 1;
            //assign data to property
            AnOrder.CustomerId = TestData;
            //test that the values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //check if ID exists
            clsOrder AnOrder = new clsOrder();
            //test to see if ID is entered
            //create test data
            int TestData = 1;
            //assign data to property
            AnOrder.StaffId = TestData;
            //test that the values are the same
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }
        [TestMethod]
        public void VinNumberPropertyOK()
        {
            //check if ID exists
            clsOrder AnOrder = new clsOrder();
            //test to see if ID is entered
            //create test data
            int TestData = 1;
            //assign data to property
            AnOrder.VinNumber = TestData;
            //test that the values are the same
            Assert.AreEqual(AnOrder.VinNumber, TestData);
        }
        [TestMethod]
        public void LocationPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            //create test data
            string TestData = "Test Location";
            //set location to test data
            AnOrder.Location = TestData;
            //test if they match
            Assert.AreEqual(AnOrder.Location, TestData);
        }
        [TestMethod]
        public void FinancePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            //create test data
            Boolean TestData = true;
            //set location to test data
            AnOrder.Finance = TestData;
            //test if they match
            Assert.AreEqual(AnOrder.Finance, TestData);
        }
        [TestMethod]
        public void PaymentStatusPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            //create test data
            Boolean TestData = true;
            //set location to test data
            AnOrder.PaymentStatus = TestData;
            //test if they match
            Assert.AreEqual(AnOrder.PaymentStatus, TestData);
        }
        [TestMethod]
        public void DatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            //create test data
            DateTime TestData = DateTime.Now;
            //set location to test data
            AnOrder.Date = DateTime.Now;
            AnOrder.Date = TestData;
            //test if they match
            Assert.AreEqual(AnOrder.Date, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            //create test data
            Decimal TestData = 100;
            //set location to test data
            AnOrder.Price = TestData;
            //test if they match
            Assert.AreEqual(AnOrder.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.OrderId != 1)
            {
}               OK = false;
            }
            Assert.IsTrue(OK);
            //??? Need to do more tests here from week 21 file
        }
        
    }
}

