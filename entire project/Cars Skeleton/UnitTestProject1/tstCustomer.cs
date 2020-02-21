using System;
using CarsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exist
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void dateAddedPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data and assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            AnCustomer.dateAdded = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.dateAdded, TestData);
        }

        [TestMethod]
        public void customerIDPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 20423;
            AnCustomer.customerID = TestData;
            Assert.AreEqual(AnCustomer.customerID, TestData);

        }

        [TestMethod]
        public void fullNamePropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "John Smith";
            AnCustomer.fullName = TestData;
            Assert.AreEqual(AnCustomer.fullName, TestData);
        }

        [TestMethod]
        public void emailPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "someone@gmail.com";
            AnCustomer.email = TestData;
            Assert.AreEqual(AnCustomer.email, TestData);
        }

        [TestMethod]
        public void mobileNumberPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int64 TestData = 07763512044;
            AnCustomer.mobileNumber = TestData;
            Assert.AreEqual(AnCustomer.mobileNumber, TestData);
        }

        [TestMethod]
        public void addressPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "1 new street, Leicester, Le3 7XL";
            AnCustomer.address = TestData;
            Assert.AreEqual(AnCustomer.address, TestData);
        }

        [TestMethod]
        public void loyaltydiscountOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.loyaltyDiscount = TestData;
            Assert.AreEqual(AnCustomer.loyaltyDiscount, TestData);
        }
    }
}



