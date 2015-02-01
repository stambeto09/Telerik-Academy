using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestFromFiveVariables
{
    class GreatestFromFiveVariables
    {
        static void Main()
        {
            Console.Write("Enter a value for first variable: ");
            double firstVariable = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for second variable: ");
            double secondVariable = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for third variable: ");
            double thirdVariable = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for fourth variable: ");
            double fourthVariable = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for fifth variable: ");
            double fifthVariable = double.Parse(Console.ReadLine());

            double firstMax = Math.Max(firstVariable, secondVariable);
            double secondMax = Math.Max(firstMax, thirdVariable);
            double thirdMax = Math.Max(secondVariable, fourthVariable);
            double fourthMax = Math.Max(thirdMax, fifthVariable);


            Console.WriteLine("The greatest one is equal to:"+fourthMax);
        }
    }
}
