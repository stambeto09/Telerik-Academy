using System;
using System.Linq;

namespace _12.ArithmeticalOperationsWithPolynoms
{
    class ArithmeticalOperationsWithPolynoms
    {

        static decimal[] SumTwoArrays(decimal[] arr1, decimal[] arr2)
        {

            int biggerLength = arr1.Length;
            int smallerLength = arr2.Length;

            if (arr2.Length > arr1.Length)
            {
                biggerLength = arr2.Length;
                smallerLength = arr1.Length;
            }

            decimal[] sumArr = new decimal[biggerLength];

            for (int i = 0; i < biggerLength; i++)
            {
                if (i > smallerLength - 1)
                {
                    sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
                }
                else
                {
                    sumArr[i] = arr1[i] + arr2[i];
                }

            }
            return sumArr;
        }


        static decimal[] SubstractArrays(decimal[] arr1, decimal[] arr2)
        {

            int biggerLength = arr1.Length;
            int smallerLength = arr2.Length;

            if (arr2.Length > arr1.Length)
            {
                biggerLength = arr2.Length;
                smallerLength = arr1.Length;
            }

            decimal[] sumArr = new decimal[biggerLength];

            for (int i = 0; i < biggerLength; i++)
            {
                if (i > smallerLength - 1)
                {
                    sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
                }
                else
                {
                    sumArr[i] = arr1[i] - arr2[i];
                }
            }
            return sumArr;
        }

        static decimal[] MultiplyArr(decimal[] arr1, decimal[] arr2)
        {
            decimal[] multiArr = new decimal[arr1.Length + arr2.Length - 1];
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    multiArr[i + j] += arr1[i] * arr2[j];
                }

            }
            return multiArr;
        }

        static string ReturnPositiveSign(decimal[] arr, int i)
        {
            if (arr[i] > 0 && arr.Length - 1 != i)
            {
                string signPlus = "+";
                return signPlus;
            }
            else
            {
                return string.Empty;
            }
        }

        static void PrintPolynom(decimal[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    if (i != 0 && i != 1)
                    {
                        Console.Write(" {2}{0:F1}x^{1}", arr[i], i, ReturnPositiveSign(arr, i));
                    }
                    else if (i == 1)
                    {
                        Console.Write(" {1}{0:F1}x", arr[i], ReturnPositiveSign(arr, i));

                    }
                    else if (i == 0)
                    {
                        Console.Write(" {1}{0:F1}", arr[i], ReturnPositiveSign(arr, i));
                    }
                }
            }
            Console.WriteLine();
        }
     
        static void Main()
        {
            Console.Write("Enter  a degree for the first polynom: ");
            int degreeFirstPolynom = int.Parse(Console.ReadLine());
            decimal[] firstArray = new decimal[degreeFirstPolynom + 1];

            Console.Write("Now enter coefficients in descending way.- from highest to smallest.");
            for (int index = 0; index < firstArray.Length; index++)
            {
                firstArray[index] = decimal.Parse(Console.ReadLine());
            }


            Console.Write("Enter a degree for the first polynom: ");
            int degreeSecondPolynom = int.Parse(Console.ReadLine());
            decimal[] secondArray = new decimal[degreeSecondPolynom + 1];

            Console.Write("Now enter coefficients in descending way.- from highest to smallest.");
            for (int index = 0; index < secondArray.Length; index++)
            {
                secondArray[index] = decimal.Parse(Console.ReadLine());
            }



            Console.Write("Array 1: ");
            PrintPolynom(firstArray);
            Console.Write("Array 2: ");
            PrintPolynom(secondArray);
            Console.WriteLine();

            Console.Write("Sum: ");
            PrintPolynom(SumTwoArrays(firstArray, secondArray));


            Console.Write("Subtraction: ");
            PrintPolynom(SubstractArrays(firstArray, secondArray));


            Console.WriteLine("Multiplication: ");
            PrintPolynom(MultiplyArr(firstArray, secondArray));
            
         
        }
    }



}
