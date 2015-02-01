using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaCalculating
{
    class DividerToFiveAndSeven
    {
        static void Main()
        {
            Console.Write("Enter a value for width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter a value for height: ");
            double height = double.Parse(Console.ReadLine());

            if (width <= 0 || height <= 0)
            {
                Console.WriteLine("Please enter a positive values.");
            }
            else
            {
                double rectangleArea = new double();
                rectangleArea = ((2 * width) + (2 * height));
                Console.WriteLine("The area of the rectangle is equal to {0}.", rectangleArea);
            }
        }
    }
}
