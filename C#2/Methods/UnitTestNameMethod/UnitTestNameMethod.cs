using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.NameMethod;

namespace UnitTestNameMethod
{
    [TestClass]
    public class UnitTestNameMethod
    {
        [TestMethod]
        public void StringTestMethod1()
        {
            string name="Ivan";
            NameMethod.PrintName(name);
            
        }
        [TestMethod]
        public void StringTestMethod2()
        {
            string name="Stanimir";
            Assert.AreEqual("Stanimir", name);
        }
    }
}
