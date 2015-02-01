using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Phone;

namespace UnitTestingMobilePhone
{
    [TestClass]
    public class PhoneCallHistoryTest
    {
        [TestMethod]
        public void CallHistoryTest()
        {
            MobilePhone testPhone = new MobilePhone("Sansung", "Japan");
            List<Call> callHistory = new List<Call>();

            Call newCall = new Call(DateTime.Now);
            newCall.Time = 15;
            newCall.DialedPhoneNumber = "0896018446";
            callHistory.Add(newCall);

            for (int index = 0; index < callHistory.Count; index++)
            {
                Console.WriteLine("Call #{0} time: {1}",index+1,callHistory[index].Time);
                Console.WriteLine("Call #{0} time: {1}",index+1,callHistory[index].DialedPhoneNumber);
            }
            
            callHistory.Clear();
        }
    }
}
