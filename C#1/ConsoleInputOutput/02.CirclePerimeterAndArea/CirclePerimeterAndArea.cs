using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter radius for circle: ");
            double radius = double.Parse(Console.ReadLine());

            if (radius <= 0)
            {
                Console.WriteLine("Please enter a valid input for radius");
            }
            else
            {


                double circleArea = Math.PI * Math.Pow(radius, 2);
                double circlePerimeter = 2 * Math.PI * radius;

                Console.WriteLine("The perimeter of circle is equal to {0}", circlePerimeter);
                Console.WriteLine("The area of circle is equal to {0}", circleArea);
            }
        }
    }
}
