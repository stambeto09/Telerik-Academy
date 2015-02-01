using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;

namespace UnitTestMobilePhone
{
    [TestClass]
    public class TestArrayOfPhones
    {
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TestIntializeArrayMethod()
        {
            int testLengthOfTheArray = -1;
            MobilePhone [] testArrayOfPhones=new MobilePhone[testLengthOfTheArray];
            Phone.Test.IntializeArray(5, testArrayOfPhones);
        }
    }
}
