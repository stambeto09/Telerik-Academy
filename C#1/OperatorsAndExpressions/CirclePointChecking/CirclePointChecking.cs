using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePointChecking
{
    class CirclePointChecking
    {
        static void Main()
        {
            Console.Write("Enter the value for x cordinate: ");
            int xCoordinate = int.Parse(Console.ReadLine());
            Console.Write("Enter the value for y cordinate: ");
            int yCoordinate = int.Parse(Console.ReadLine());

            bool absCondition = ((Math.Abs(yCoordinate) <= 5 && (Math.Abs(xCoordinate) <= 5)));
            
            if(absCondition==true)
            {
                Console.WriteLine("The point with coordinates x and y is within the Circle (O,5)");
            }
            else
            {
                Console.WriteLine("The point with coordinates x and y isn't within the Circle (O,5)");
            }

        }
    }
}
