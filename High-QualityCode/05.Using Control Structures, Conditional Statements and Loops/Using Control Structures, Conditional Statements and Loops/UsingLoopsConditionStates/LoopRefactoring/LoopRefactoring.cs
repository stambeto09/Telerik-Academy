using System;
using System.Linq;

namespace LoopRefactoring
{
    class LoopRefactoring
    {
        static void Main()
        {
            Console.Write("Enter the expected value: ");
            int expectedValue = int.Parse(Console.ReadLine());
            int[] array = new int[1000];
            bool isFound = false;
            for (int index = 0; index < 100; index++)
            {
                Console.WriteLine(array[index]);

                if (index % 10 == 0)
                {
                    if (array[index] == expectedValue)
                    {
                        isFound = true;
                    }
                }
            }
            // More code here
            if (isFound)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}
