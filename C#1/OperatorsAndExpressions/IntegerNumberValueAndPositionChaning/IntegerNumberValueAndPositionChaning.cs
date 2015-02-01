using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerNumberValueAndPositionChaning
{
    class IntegerNumberValueAndPositionChaning
    {
        static void Main()
        {
            Console.Write("Enter your number n: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter your position p : ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << position;
            int resultNumber = number ^ mask;
            Console.WriteLine("The modified number is: {0}", resultNumber);
            
            
        }
        }
    }

