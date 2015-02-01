using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm ;

        static void Main()
        {
            Console.Write("Enter a value for last number in sequence: ");
            int number = int.Parse(Console.ReadLine());
            bool[] array = new bool[number];

            for (int i = 2; i < Math.Sqrt(array.Length); i++)
            {

                if (array[i] == false)
                {

                    for (int j = i * i; j < array.Length; j = j + i)
                    {


                        array[j] = true;


                    }

                }

            }


            for (int i = 2; i < array.Length; i++)
            {

                if (array[i] == false)
                {

                    Console.Write("{0} ", i);

                }

            }

            Console.WriteLine();

        }

    } 
}
