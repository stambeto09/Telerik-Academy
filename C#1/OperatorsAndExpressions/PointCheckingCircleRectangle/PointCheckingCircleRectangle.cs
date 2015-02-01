using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCheckingCircleRectangle
{
    class PointCheckingCircleRectangle
    {
        static void Main()
        {
            Console.Write("Enter x-coordinate: ");
            int xCoordinate = int.Parse(Console.ReadLine());

            Console.Write("Enter y-coordinate: ");
            int yCoordinate = int.Parse(Console.ReadLine());
            bool xCondition = ((xCoordinate > 6) || (xCoordinate < -3));
            bool yCondition = ((yCoordinate > 3) || (yCoordinate <- 3));
            if ((yCondition==true) && (yCondition==true))
            {
                Console.WriteLine("The point with coordinates x={0} and y={1} is in the circle or rectangle", xCoordinate, yCoordinate);
            }
            else
            {
                Console.WriteLine("The point with coordinates x={0} and y={1} is out of the circle or rectangle ", xCoordinate, yCoordinate);
            }
        }
    }
}
