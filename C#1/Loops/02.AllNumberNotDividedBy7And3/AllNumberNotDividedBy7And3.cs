using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AllNumberNotDividedBy7And3
{
    class AllNumberNotDividedBy7And3
    {
        static void Main()
        {
            Console.Write("Enter a value for n: ");
            int number=int.Parse(Console.ReadLine());

            for (int index = 1; index <= number; index++)
            {
                if (index%21!=0)
                {
                    Console.WriteLine(index);
                }
            }
        }
    }
}
