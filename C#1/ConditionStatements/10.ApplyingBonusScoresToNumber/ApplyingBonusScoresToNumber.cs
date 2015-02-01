using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ApplyingBonusScoresToNumber
{
    class ApplyingBonusScoresToNumber
    {
        static void Main()
        {
            
            Console.Write("Enter a digit in interval [1;9]: ");
            int digit = int.Parse(Console.ReadLine());


            switch (digit)
            {
                
                default: Console.WriteLine("Bad input!"); break;
                case 1: Console.WriteLine(digit * 10); break;
                case 2: Console.WriteLine(digit * 10); break;
                case 3: Console.WriteLine(digit * 10); break;
                case 4: Console.WriteLine(digit * 100); break;
                case 5: Console.WriteLine(digit * 100); break;
                case 6: Console.WriteLine(digit * 100); break;
                case 7:
                case 8:
                case 9: Console.WriteLine(digit * 1000); break;
            }
            
        }
    }
}
