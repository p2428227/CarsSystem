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
        public void dateAddedPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data and assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            AnCustomer.DateAdded = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void customerIDPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 20423;
            AnCustomer.CustomerID = TestData;
            Assert.AreEqual(AnCustomer.CustomerID, TestData);

        }

        [TestMethod]
        public void fullNamePropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "John Smith";
            AnCustomer.FullName = TestData;
            Assert.AreEqual(AnCustomer.FullName, TestData);
        }

        [TestMethod]
        public void emailPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "someone@gmail.com";
            AnCustomer.Email = TestData;
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void mobileNumberPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int64 TestData = 07763512044;
            AnCustomer.MobileNumber = TestData;
            Assert.AreEqual(AnCustomer.MobileNumber, TestData);
        }

        [TestMethod]
        public void addressPropertyOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "1 new street, Leicester, Le3 7XL";
            AnCustomer.Address = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void loyaltydiscountOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.LoyaltyDiscount = TestData;
            Assert.AreEqual(AnCustomer.LoyaltyDiscount, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with method 
            Int32 CustomerID = 1234;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record of data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with method 
            Int32 CustomerID = 1234;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check customer no
            if (AnCustomer.CustomerID != 1234)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 CustomerID = 1234;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.DateAdded != Convert.ToDateTime("20/02/2020"))
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 CustomerID = 1233;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.FullName != "cj black")
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 CustomerID = 1234;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Address != "2 long road")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 CustomerID = 1234;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Email != "cj@gmail.com")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestMobileNumberFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 CustomerID = 1234;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.MobileNumber != 44776352045)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestLoyaltyDiscountFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 CustomerID = 1234;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.LoyaltyDiscount != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }



}







