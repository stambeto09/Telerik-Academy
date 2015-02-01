using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestTimer
    {
        [TestMethod]
        public void TestTimerMethod()
        {
            Timer.ExecuteTime(1, 5);
        }
    }
}
