using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;

namespace UnitTestMobilePhone
{
    [TestClass, System.Runtime.InteropServices.GuidAttribute("FE148F15-1CB1-4C93-87CF-B290EC48E9F8")]
    public class TestBatteryClass
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestModelOfBattery()
        {
            Battery phoneBatteryModel = new Battery("DU");
        }

        
    }
}
