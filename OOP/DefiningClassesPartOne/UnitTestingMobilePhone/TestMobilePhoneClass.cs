using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;

namespace UnitTestMobilePhone
{
    [TestClass]
    public class TestMobilePhoneClass
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMobilePhonePrice()
        {
            MobilePhone testPhonePrice = new MobilePhone("TestModel", "TestManufacturer");
            testPhonePrice.Price = -10m;
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMobilePhoneModel()
        {
            MobilePhone testPhoneModel = new MobilePhone("a","Manufacturer");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMobilePhoneManufacturer()
        {
            MobilePhone testPhoneManufacturer = new MobilePhone("Samsung", "a");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMobilePhoneOwnerName()
        {
            MobilePhone testPhoneNameOwner= new MobilePhone("Samsung", "George");
            testPhoneNameOwner.Name = "a";
        }
    }
}
