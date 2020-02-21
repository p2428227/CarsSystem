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
    public void CustomerIDOK()
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
    public void StaffIDOK()
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
    public void vinNumberOK()
    {
        //check if ID exists
        clsOrder AnOrder = new clsOrder();
        //test to see if ID is entered
        //create test data
        int TestData = 1;
        //assign data to property
        AnOrder.vinNumber = TestData;
        //test that the values are the same
        Assert.AreEqual(AnOrder.vinNumber, TestData);
    }
    [TestMethod]
    public void locationOK()
    {
        clsOrder AnOrder = new clsOrder();
        //create test data
        string TestData = "TestLocation";
        //set location to test data
        AnOrder.location = TestData;
        //test if they match
        Assert.AreEqual(AnOrder.location, TestData);
    }
    [TestMethod]
    public void FinanceOK()
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
    public void paymentStatusOK()
    {
        clsOrder AnOrder = new clsOrder();
        //create test data
        Boolean TestData = true;
        //set location to test data
        AnOrder.paymentStatus = TestData;
        //test if they match
        Assert.AreEqual(AnOrder.paymentStatus, TestData);
    }
    [TestMethod]
    public void DateOK()
    {
        clsOrder AnOrder = new clsOrder();
        //create test data
        DateTime TestData = DateTime.Now;
        //set location to test data
        AnOrder.Date = DateTime.Now;
        //test if they match
        Assert.AreEqual(AnOrder.Date, TestData);
    }
    [TestMethod]
    public void PriceOK()
    {
        clsOrder AnOrder = new clsOrder();
        //create test data
        Decimal TestData = 100;
        //set location to test data
        AnOrder.Price = TestData;
        //test if they match
        Assert.AreEqual(AnOrder.Price, TestData);
    }

    }
