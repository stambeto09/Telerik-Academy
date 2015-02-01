using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;
using System.Collections.Generic;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestIEnumerable
    {
        [TestMethod]
        public void TestIEnumerableSum()
        {
            List<decimal> testList = new List<decimal> { 1, 2, 3, 4, 5 };
            Console.WriteLine(testList.CalculateSum<decimal>());
        }

        [TestMethod]
        public void TestIEnumerableProduct()
        {
            List<decimal> testList = new List<decimal> { 1, 2, 3, 4, 5 };
            Console.WriteLine(testList.CalculateProduct<decimal>());
        }

        [TestMethod]
        public void TestIEnumerableMinValue()
        {
            List<decimal> testList = new List<decimal> { 1, 2, 3, 4, 5 };
            Console.WriteLine(testList.FindMinValue<decimal>());
        }

        [TestMethod]
        public void TestIEnumerableMaxValue()
        {
            List<decimal> testList = new List<decimal> { 1, 2, 3, 4, 5 };
            Console.WriteLine(testList.FindMaxValue<decimal>());
        }

        [TestMethod]
        public void TestIEnumerableCalculateAverage()
        {
            List<decimal> testList = new List<decimal> { 1, 2, 3, 4, 5 };
            Console.WriteLine(testList.CalculateAverage<decimal>());
        }
    }
}
