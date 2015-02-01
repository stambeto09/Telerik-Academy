using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChecking
{
    class PrimeNumberChecking
    {
        static void Main ()
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            if ((number < 0) || (number >= 100))
            {
                Console.WriteLine("Please enter a positive number existing in the interval of (0;100]");
            }

            if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                Console.WriteLine("Your number is prime!");
            }

            else
            {

                if ((number / 2 != 0) || (number / 3 != 0) || (number / 5 != 0) || (number / 7 != 0))
                {
                    Console.WriteLine("Your number is prime!");
                }
                else
                {
                    Console.WriteLine("Your number is not prime!");
                }
            }
           
        }
    }
}
