using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividerToFiveAndSeven
{
    class DividerToFiveAndSeven
    {
        static void Main()
        {
            
            Console.Write("Enter your dividend: ");
            int dividend = int.Parse(Console.ReadLine());
            
            Console.Write("Is your dividend dividing on 7 and 5 at the same time?- ");
            Console.WriteLine((dividend % 5 != 0 || dividend % 7 != 0) ? false : true);
           
            }
        }
    }

