using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopPrinciplesPartTwo;

namespace UnitTestProjectShapes
{
    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void TestMethodCircle()
        {
            var testArrayOfCircles = new Circle[5]
            {
                new Circle(15),
                new Circle(13),
                new Circle(11),
                new Circle(5),
                new Circle(25),
            };

            foreach (Circle  circle in testArrayOfCircles)
            {
                Console.WriteLine(circle.CalculateSurface());
            }
        }
    }
}
