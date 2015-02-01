using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonTypeSystem;

namespace UnitTestProject
{
    [TestClass]
    public class TestNullableAge
    {
        [TestMethod]
        public void PersonTest()
        {
            Person testPerson = new Person();
            testPerson.Name = "Dimitur";
            Console.WriteLine(testPerson.ToString());
        }
    }
}
