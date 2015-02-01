using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CalculatingSumWithAccuracy
{
    class CalculatingSumWithAccuracy
    {
        static void Main()
        {
            double firstNumber = 1.1234567;
            double secondNumber = 1.1234567;
            double numberSum = firstNumber + secondNumber;
            Console.WriteLine("The calculating with accuracy of 0.001 is equal to:{0:0.001}",numberSum);
        }
    }
}
