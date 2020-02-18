using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCar ACar = new clsCar();
            Boolean TestData = true;

            ACar.Active = TestData;

            Assert.AreEqual(ACar.Active, TestData);
        }
    }
}
