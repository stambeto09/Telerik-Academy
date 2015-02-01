using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTenNumbers
{
    class FirstTenNumbers
    {
        static void Main()
        {
            for (int index = 2; index <=11; index++)
            {
                if (index % 2 != 0)
                {
                    Console.WriteLine(index * -1);
                }
                else
                {
                    Console.WriteLine(index);
                }
            }
        }
    }
}
