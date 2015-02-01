using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OopPrinciplesPartTwo;

namespace UnitTestProjectShapes
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestMethodtriangle()
        {
            var testArrOfTriangle = new Triangle[3]
            {
                new Triangle(15, 13),
                new Triangle(12, 15),
                new Triangle(16, 2),
            };

            foreach (Triangle triangle in testArrOfTriangle)
            {
                Console.WriteLine(triangle.CalculateSurface());
            }
    
        }
    }
}
