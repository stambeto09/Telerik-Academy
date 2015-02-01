using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using ExtensionMethods;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestSubstring
    {
        [TestMethod]
        public void SubstringUnitTest()
        {
            StringBuilder testStringBuilder = new StringBuilder("Georgi");
            Console.WriteLine(testStringBuilder.Substring(-1, 2));
        }
    }
}
