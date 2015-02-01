using System;
using System.Linq;

namespace _14.MathematicalOperations
{
    public class MathematicalOperations
    {
        public static int CalculateMinimumValue( params int[] numberOfSequence )
        {
            Array.Sort(numberOfSequence);
            
            return numberOfSequence[0];
        }

        public static int CalculateMaximumValue( params int[] numberOfSequence )
        {
            Array.Sort(numberOfSequence);

            return numberOfSequence[numberOfSequence.Length - 1];
        }

        public static int  CalculateAverage( params int[] numbersOfSequence )
        {
            int sumOfElements = 0;

            for (int index = 0; index < numbersOfSequence.Length; index++)
            {
                sumOfElements += numbersOfSequence[index];
            }

            int averageValue = 0;
            int numberOfElements = numbersOfSequence.Length;

            averageValue = sumOfElements / numberOfElements;

            return averageValue;
        }

        public static int CalculateSum( params int[] numbersOfSequence )
        {
            int sequenceSum = 0;

            for (int index = 0; index < numbersOfSequence.Length; index++)
            {
                sequenceSum+=numbersOfSequence[index];
            }

            return sequenceSum;
        }

        public static int CalculateProduct( params int[] numbersOfSequence )
        {
            int product = 1;

            for (int index = 0; index < numbersOfSequence.Length; index++)
            {
                product *= numbersOfSequence[index];
            }

            return product;
        }
        static void Main()
        {
            Console.Write(" Enter a number of elements: ");
            int numbers = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[numbers];

            for (int index = 0; index < arrayOfNumbers.Length; index++)
            {

                Console.Write("Enter element number {0} : ", index);
                arrayOfNumbers[index] = int.Parse(Console.ReadLine());

            }

            int minimumResult = CalculateMinimumValue(arrayOfNumbers);
            Console.WriteLine("Your minimum value is equal to {0}", minimumResult);

            int maximumResult = CalculateMaximumValue(arrayOfNumbers);
            Console.WriteLine("Your maximum value is equal to {0}", maximumResult);

            int averageResult = CalculateAverage(arrayOfNumbers);
            Console.WriteLine("Your average value of sequence is equal to {0}", averageResult);
            
            int sumOfSequence =CalculateSum(arrayOfNumbers);
            Console.WriteLine("Your sum of elements in sequence is equal to {0}", sumOfSequence);

            int productOfSequence = CalculateProduct(arrayOfNumbers);
            Console.WriteLine("Your product of elements in sequence is equal to {0}", productOfSequence);

        }
    }
}
