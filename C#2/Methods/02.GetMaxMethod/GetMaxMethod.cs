using System;
using System.Linq;

namespace _02.GetMaxMethodNamespace

{
    //Write a method GetMax() with two parameters that returns the bigger of two integers.
    //Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

    class GetMaxMethod
    {
        //Getting maximum value from  three parameters and returning the result;
        public static double GetMax (double firstParam,double secondParam,double thirdParam)
        {
            return Math.Max(Math.Max(firstParam, secondParam), thirdParam);
        }
        static void Main()
        {   //Inputting;
            Console.Write("Enter the first value: ");
            double firstValue = double.Parse(Console.ReadLine());

            Console.Write("Enter the second value: ");
            double secondValue = double.Parse(Console.ReadLine());

            Console.Write("Enter the third value: ");
            double thirdValue = double.Parse(Console.ReadLine());

            //Printing the result;
            Console.WriteLine("The biggest value from {0},{1} and {2} is: {3}",firstValue,secondValue,thirdValue,GetMax(firstValue, secondValue,thirdValue ));
        }
    }
}
