using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInArrayMethodNamespace;

namespace UnitTestNumberInArrayMethod
{
    [TestClass]
    public class UnitTestNumberInArrayMethod 
    {
        [TestMethod]
        public void TestFindNumberInSmallArray()
        {
            int[] array = { 1, 2, 4, 2, 1, 1, 1 };
            
            int someNumber = 2;
            int result = NumberInArrayMethod.FindNumber(array, someNumber);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestFindNumberInBigArray()
        {
            int[] array = { 1, 2, 4, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int someNumber = 2;
            int result = NumberInArrayMethod.FindNumber(array, someNumber);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestFindNumberInNullArray()
        {
            int someNumber = 2;
            NumberInArrayMethod.FindNumber(null, someNumber);
      
        }
    }
}
