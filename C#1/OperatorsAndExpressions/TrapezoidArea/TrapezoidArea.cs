using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("Enter a value for the base: ");
            double baseLenght = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for the small base: ");
            double smallBase = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for the height: ");
            double height = double.Parse(Console.ReadLine());

            if ((baseLenght <= 0) || (smallBase <= 0) || (height <= 0))
            {
                Console.WriteLine("Please, enter a valid positive values for bases and height.");
            }
            else if (baseLenght <= smallBase)
            {
                Console.WriteLine("The small base can't be bigger or equal to the big base.");
            }
            else
            {
                double trapezoidArea = ((baseLenght + smallBase) / 2) * height;
                Console.WriteLine("The trapezoid area is equal to {0}", trapezoidArea);

            }

        }
    }
}
