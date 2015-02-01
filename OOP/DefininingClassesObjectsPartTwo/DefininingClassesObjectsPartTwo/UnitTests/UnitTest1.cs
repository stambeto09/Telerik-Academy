using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefiningClassesObjectsPartTwo;

namespace UnitTests
{
    [TestClass]
    public class TestMatrixClass
    {
        [TestMethod]
        public void TestMatrix()
        {
            Matrix<int> testMatrix = new Matrix<int>(2, 2);
            for (int row = 0; row < testMatrix.GetRows; row++)
            {
                for (int col = 0; col < testMatrix.GetCols; col++)
                {
                    Console.WriteLine(testMatrix[row,col]);
                }
            }
        }
    }
}
