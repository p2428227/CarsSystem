using System;
using CarsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }

        [TestMethod]
        public void StaffNumberOK()
        {
            clsStaff aStaff = new clsStaff();
            int testData = 854904354;
            aStaff.staffNumber = testData;

            Assert.AreEqual(aStaff.staffNumber, testData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string testData = "Jason Mars";
            aStaff.fullName = testData;

            Assert.AreEqual(aStaff.fullName, testData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string testData = "Jason@Mars.com";
            aStaff.emailAddress = testData;

            Assert.AreEqual(aStaff.emailAddress, testData);
        }

        [TestMethod]
        public void HoursPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            float testData = 17.5f;
            aStaff.hours = testData;

            Assert.AreEqual(aStaff.hours, testData);
        }

        [TestMethod]
        public void JoinDatePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime testData = DateTime.Now.Date;
            aStaff.joinDate = testData;

            Assert.AreEqual(aStaff.joinDate, testData);
        }

        [TestMethod]
        public void BankAccountNumberPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            int testData = 875439543;
            aStaff.bankAccountNumber = testData;

            Assert.AreEqual(aStaff.bankAccountNumber, testData);
        }

        [TestMethod]
        public void StaffDiscountPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            bool testData = true;
            aStaff.staffDiscount = testData;

            Assert.AreEqual(aStaff.staffDiscount, testData);
        }
    }
}
