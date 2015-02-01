using System;
using System.Linq;


namespace _01a.PrintingAMultidimensionalMatrix
{
    class PrintingAMultidimensionalMatrix
    {
        //Write a program that fills and prints a matrix of size (n, n) as shown below:
        public static void PrintArray(int [,] matrixParameter, int colsAndRows)
        {
            
            for (int row = 0; row <matrixParameter.GetLength(0); row++)
            {

                for (int col= 0; col < matrixParameter.GetLength(1); col++)
                {

                    matrixParameter[row,col]=(row+1)+(col*4);
                    Console.Write("{0,4} ",matrixParameter[row,col]);
                    
                }
                Console.WriteLine();
               
            }

        }
        static void Main()
        {
            Console.Write("Enter the number of rows and columns: ");
            int numberOfColumnsAndRows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numberOfColumnsAndRows, numberOfColumnsAndRows];

            PrintArray(matrix, numberOfColumnsAndRows);

        }
    }
}
