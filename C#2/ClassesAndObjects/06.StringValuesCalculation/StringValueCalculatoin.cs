using System;
using System.Linq;

namespace _06.StringValuesCalculation
{
    class StringValueCalculatoin
    {
        static void CalculateSum(string stringNumbers)
        {
            string [] numbersInString=stringNumbers.Split(' ');
            int [] numberValues = new int[numbersInString.Length];
            for (int index = 0; index < numbersInString.Length; index++)
            {
                int currentConverter=int.Parse(numbersInString[index]);
                numberValues[index] = currentConverter;
            }

            int sum = 0;
            for (int index = 0; index < numberValues.Length; index++)
            {
                sum += numberValues[index];
                
            }
            Console.WriteLine("The sum of the numbers is equal to: {0}",sum);

        }
        static void Main()
        {
            Console.Write("Enter your numbers separated by interval: ");
            string numbers = Console.ReadLine();
            CalculateSum(numbers);
            //string s = "there is a cat";
            //string[] words = s.Split(' ');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
