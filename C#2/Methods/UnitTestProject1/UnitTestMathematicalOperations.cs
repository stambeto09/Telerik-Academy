using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _14.MathematicalOperations;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestMathematicalOperations
    {
        [TestMethod]
        public void TestingCalculateMinimumMethodWithNormalValues()
        {
            int[] testArray = { 6, 5, 1, 3, 9, 10 };
            MathematicalOperations.CalculateMinimumValue(testArray);
        }
        [TestMethod]
        public void TestingCalculateMinimumMethodWithOverflowValues()
        {
            int[] secondTestArray = { 2147483647, 5, 4, 3 };
            MathematicalOperations.CalculateMinimumValue(secondTestArray);
        }

        [TestMethod]
        public void TestingCalculateMaximumMethodWithNormalValues()
        {
            int[] thirdTestArray = { 356, 357, 354, 358 };
            MathematicalOperations.CalculateMaximumValue(thirdTestArray);
        }
    }
}
