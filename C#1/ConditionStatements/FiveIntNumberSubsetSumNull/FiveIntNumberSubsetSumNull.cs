using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveIntNumberSubsetSumNull
{
    class FiveIntNumberSubsetSumNull
    {
        static void Main()
        {
            Console.Write("Enter the first integer number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third integer number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth integer number: ");
            int fourthNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the fifth integer number: ");
            int fifthNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            //Checking sum with first number;
            if (firstNumber+secondNumber==0)
            {
                counter++;
            }
            if (firstNumber + secondNumber + thirdNumber == 0)
            {
                counter++;
            }
            if (firstNumber+secondNumber+thirdNumber+fourthNumber==0)
            {
                counter++;
            }
            if (firstNumber+secondNumber+thirdNumber+fourthNumber+fifthNumber==0)
            {
                counter++;
            }

            //Checking sum with second number;

            if (secondNumber+thirdNumber==0)
            {
                counter++;
            }
            if (secondNumber+thirdNumber+fourthNumber==0)
            {
                counter++;
            }

            if (secondNumber+thirdNumber+fourthNumber+fifthNumber==0)
            {
                counter++;
            }

            //Checking sum with third number;

            if (thirdNumber+fourthNumber==0)
            {
                counter++;    
            }
            if (thirdNumber+fourthNumber+fifthNumber==0)
            {
                counter++;
            }
            
            //Checking sum with fourth number;

            if (fourthNumber+fifthNumber==0)
            {
                counter++;
            }

            //Printing the number of subsets
            Console.WriteLine("The subsets with sum equal to 0 are {0}",counter);


        }
        }
    }

