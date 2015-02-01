using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopPrinciplesPartTwo;

namespace UnitTestProjectShapes
{
    [TestClass]
    public class TestRectangle
    {
        [TestMethod]
        public void TestMethodRectangle()
        {
            var testArrOfRectangle = new Rectangle[5]
            {
                new Rectangle(12,13),
                new Rectangle(10,5),
                new Rectangle(12,25),
                new Rectangle(46,2),
                new Rectangle(12,34),
            };

            foreach (var rectangle in testArrOfRectangle)
            {
                Console.WriteLine(rectangle.CalculateSurface());
            }
        }
    }
}
