using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrderThreeValues
{
    class DescendingOrderThreeValues
    {
        static void Main()
        {
            Console.Write("Enter the first value: ");
            double firstValue = double.Parse(Console.ReadLine());
            Console.Write("Enter the second value: ");
            double secondValue = double.Parse(Console.ReadLine());
            Console.Write("Enter the third value: ");
            double thirdValue = double.Parse(Console.ReadLine());

            if ((firstValue==secondValue)||(firstValue==thirdValue)||(secondValue==thirdValue)||(secondValue==firstValue)||(thirdValue==firstValue)||(thirdValue==secondValue))
            {
                Console.WriteLine("Please, enter a different values for each variable");
            }

            if (firstValue<secondValue)
            {
                if (firstValue<thirdValue)
                {
                    if (secondValue<thirdValue)
                    {
                        Console.WriteLine(firstValue);
                        Console.WriteLine(secondValue);
                        Console.WriteLine(thirdValue);
                    }
                    else
                    {
                        Console.WriteLine(firstValue);
                        Console.WriteLine(thirdValue);
                        Console.WriteLine(secondValue);
                    }
                }
            }

            if (secondValue<firstValue)
            {
                if (secondValue<thirdValue)
                {
                    if (firstValue<thirdValue)
                    {
                        Console.WriteLine(secondValue);
                        Console.WriteLine(firstValue);
                        Console.WriteLine(thirdValue);
                    }
                    else
                    {
                        Console.WriteLine(secondValue);
                        Console.WriteLine(thirdValue);
                        Console.WriteLine(thirdValue);
                    }
                }
            }

            if (thirdValue<firstValue)
            {
                if (thirdValue<secondValue)
                {
                    if (firstValue<secondValue)
                    {
                        Console.WriteLine(thirdValue);
                        Console.WriteLine(firstValue);
                        Console.WriteLine(secondValue);
                    }
                    else
                    {
                        Console.WriteLine(thirdValue);
                        Console.WriteLine(secondValue);
                        Console.WriteLine(firstValue);
                    }
                }
            }
        }
    }
}
