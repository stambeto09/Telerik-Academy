using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestIntegerNumbersWithLinq
    {
        [TestMethod]
        public void UnitTestIntNumbersLinq()
        {
            int[] numbers = new int[] { 1, 2, 3, 21, 63, 15, 7, 105 };

            var sievedNumber =
                from number in numbers
                where number % 21 == 0
                select number;

            foreach (var number in sievedNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
