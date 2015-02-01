using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.NameMethod;

namespace UnitTestsMethodsHomeworkTest
{
    [TestClass]
    public class UnitTestPrintNameMethod
    {
        [TestMethod]
        public void TestPrintMethod()
        {
            string testName = "Pesho";
            string result=NameMethod.PrintName(testName);
            Console.WriteLine(result);
        }
    }
}
