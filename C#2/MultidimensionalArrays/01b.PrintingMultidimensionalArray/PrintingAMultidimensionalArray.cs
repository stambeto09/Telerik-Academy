using System;
using System.Linq;

namespace _01b.PrintingMultidimensionalArray
{
    class PrintingAMultidimensionalArray
    {
        public static void PrintMatrix(int [,]matrix,int rows,int cols)
        {
            int digit = 1;
            for (int col =0; col <cols; col++)
            {
                if (col%2==0)//for even column
                {
                    for (int row = 0; row <rows; row++)
                    {
                        matrix[row, col] = digit;
                        digit++;
                    }
                    
                }

                else if (col%2!=0)
                {
                    for (int row =rows-1; row>=0; row--)
                    {
                        matrix[row, col] = digit;
                        digit++;
                    }
                    
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.Write("Enter a value for rows and cols of the matrix: ");
            int length = int.Parse(Console.ReadLine());
            int [,] arrayMatrix = new int[length, length];

            PrintMatrix(arrayMatrix, length, length);



            
        }
    }
}
