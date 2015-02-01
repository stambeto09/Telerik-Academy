using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestArrayOfNumbers
    {
        [TestMethod]
        public void TestPrintingNumbersDividingBy21()
        {
            int[] numbers = new int[] { 1, 2, 3, 21, 63, 15, 7, 105 };
            List<int> listOfNumbers = new List<int>();
            
            for (int index = 0; index < numbers.Length; index++)
            {
                listOfNumbers.Add(numbers[index]);
            }
            List<int> sievedList = listOfNumbers.FindAll(number => number % 21 == 0);

            foreach (var number in sievedList)
            {
                Console.WriteLine(number);
            }
        }

    }
}
