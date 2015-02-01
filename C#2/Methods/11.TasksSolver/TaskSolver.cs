using System;
using System.Linq;
using System.Numerics;

namespace _13.TasksSolver
{
    public class TaskSolver
    {
        public static BigInteger ReversingNumber(BigInteger currentNumber, BigInteger result)
        {

            while (currentNumber > 0)
            {
                result = result * 10 + currentNumber % 10;
                currentNumber /= 10;
            }

            return result;
        }

        public static int FindAverageElementInOddSequence(int [] sequence,int averageElement)
        {
            Array.Sort(sequence);
            averageElement = sequence[(sequence.Length - 1) / 2];

            return averageElement;
        }

        public static int[] FindAverageElementInEvenSequence(int [] sequence, int firstAverageElement,
                                                             int secondAverageElement, int [] results)
        {
            Array.Sort(sequence);

            firstAverageElement = sequence [(sequence.Length - 1) / 2];
            secondAverageElement=sequence [((sequence.Length - 1) / 2+1)];

            results[0] = firstAverageElement;
            results[1] = secondAverageElement;

            return results;                        
        }

        public static decimal LinearEquation(decimal aArgument, decimal bArgument)
        {
            //a*x+b=0;
            decimal xArgument = 0;
            xArgument = (-bArgument) / aArgument;
            return xArgument;
        }
        static void Main()
        {
            Console.WriteLine("Enter: ");
            Console.WriteLine("1 for reversing the number;");
            Console.WriteLine("2 for calculating the average of a sequence;");
            Console.WriteLine("3 for solving a linear equation a*x+b=0;");
            Console.Write("Enter your choice here: ");
            int taskChecker = int.Parse(Console.ReadLine());

            //If the customer choose to reversing the number;
            if (taskChecker==1)
            {
                Console.Write("Enter the number you want to reverse: ");
                BigInteger number = BigInteger.Parse(Console.ReadLine());
                BigInteger resultFromReversing=0;
                Console.WriteLine("Your number {0} in reversed type is {1}"
                                  , number, ReversingNumber(number, resultFromReversing));
            }

            //If the customer choose to find an average value in sequence, we have two cases:
            //1) If the length of sequence is even;
            if (taskChecker==2)
            {
                Console.Write("Enter the length of the sequence: ");
                int lengthOfSequence = int.Parse(Console.ReadLine());

                int[] sequenceOfNumbers = new int[lengthOfSequence];

                for (int index = 0; index < sequenceOfNumbers.Length; index++)
                {
                    sequenceOfNumbers[index] = int.Parse(Console.ReadLine());
                }

                //1) If the length of sequence is even;

                if (lengthOfSequence%2==0)
                {
                    int averageElementInEvenSequence = 0;
                    int secondAverageElementInEvenSequence = 0;
                    int[] averageElementsInSequence = new int[2];
                    int [] array=FindAverageElementInEvenSequence(sequenceOfNumbers, averageElementInEvenSequence
                                                                  , secondAverageElementInEvenSequence, averageElementsInSequence);

                    Console.Write("The elements are two because the length is even number: ");
                    for (int index = 0; index < array.Length; index++)
                    {

                        Console.Write(array[index]);

                        if (index==0)
                        {
                            Console.Write(" and ");
                        }

                    }
                    Console.WriteLine(".");
                    
                }

                //2)Or if  the length of sequence is odd;

                else if (lengthOfSequence%2!=0)
                {

                    int averageElementInOddSequence = 0;
                    int resultFromOddSequence = FindAverageElementInOddSequence(sequenceOfNumbers, averageElementInOddSequence);
                    Console.WriteLine("The average element in sequence is {0}. ",resultFromOddSequence);

                }  

            }
            
            if (taskChecker==3)
            {
                
                Console.Write("Enter your linear equation a*x+b=0 here: ");
                string equation = Console.ReadLine();
                
                //After we gave a string, we are trying to find 'a' and 'b' symbol and then to parse them 
                //Into decimal values;
                int multiplyingSymbolIndex = equation.LastIndexOf("*");
                string aSymbol = equation.Substring(0,multiplyingSymbolIndex);
                decimal aValue = Convert.ToDecimal(aSymbol);
                
                int plusSymbolIndex=equation.LastIndexOf("+");
                int equalSymbolIndex=equation.LastIndexOf("=");
                int lengthOfBNumber=equalSymbolIndex-plusSymbolIndex-1;
                string bSymbol = equation.Substring(plusSymbolIndex+1,lengthOfBNumber);
                decimal bValue = Convert.ToDecimal(bSymbol);

                decimal resultOfLinearEquation = LinearEquation(aValue, bValue);

                Console.WriteLine("The result from linear equation is {0}. ", resultOfLinearEquation);

            }

            if ((taskChecker!=1) || (taskChecker!=2) || (taskChecker!=3))
            {
                Console.WriteLine("Please enter a valid number!!");
            }


        }
    }
}
