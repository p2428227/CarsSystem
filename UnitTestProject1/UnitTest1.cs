using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCar ACar = new clseCar();
            Boolean TestData = true;

            ACar.Active = TestData;

            Assert.AreEqual(ACar.Active, TestData);
        }
    }
}
