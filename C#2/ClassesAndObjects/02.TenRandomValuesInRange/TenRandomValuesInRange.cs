using System;
using System.Linq;

namespace _02.TenRandomValuesInRange
{
    class TenRandomValuesInRange
    {
        static void Main()
        {
            for (int i = 0; i < 9; i++)
            {
                Random randomNumber = new Random();
                int number = randomNumber.Next(100)+101;
                Console.WriteLine(number);
                
            }

        }
    }
}
