using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter a value for a: ");
            double aArgument = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for b: ");
            double bArgument = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for c: ");
            double cArgument = double.Parse(Console.ReadLine());

            Console.WriteLine("The input quadratic Equation is: {0}x^2" + "+" + "{1}x" + "+" + "{2}=0", aArgument, bArgument, cArgument);
            double Determinant = Math.Sqrt((bArgument * bArgument - 4 * aArgument * cArgument));

            double x1 = (-bArgument + Determinant) / 2 * aArgument;
            double x2 = (-bArgument - Determinant) / 2 * aArgument;

            if (Determinant > 0)
            {
                Console.WriteLine("The quadratic equation has 2 real roots: x1={0} and x2={1}. ", x1, x2);
            }
            else if (Determinant == 0)
            {
                Console.WriteLine("The quadratic equation has 2 equal roots: x1=x2={0} ", x1);
            }
            else
            {
                Console.WriteLine("The quadratic equation doesn't have any real roots");
            }
 
        }
    }
}
