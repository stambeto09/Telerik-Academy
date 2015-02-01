using System;

namespace RotatingWalk
{
    public class Matrix
    {
        private static void ChangeDirections(ref int xDirection, ref int yDirection)
        {
            int[] xDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] yDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int elementIndex = 0;
            int numberOfDirections = 8;
            
            for (int count = 0; count < numberOfDirections; count++)
            {
                if (xDirections[count] == xDirection && yDirections[count] == yDirection)
                {
                    elementIndex = count;
                    break;
                }
            }

            if (elementIndex == 7)
            {
                xDirection = xDirections[0];
                yDirection = yDirections[0];
                return;
            }

            xDirection = xDirections[elementIndex + 1];
            yDirection = yDirections[elementIndex + 1];
        }

        private static bool CheckDirections(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            int numberOfDirections = 8;
            for (int i = 0; i < numberOfDirections; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter a positive number: ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number between [0, 100]");
                input = Console.ReadLine();
            }
            int[,] matrix = GenerateRotatingWalkMatrix(n);
            PrintMatrix(n, matrix);
        }

        private static void PrintMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static int[,] GenerateRotatingWalkMatrix(int n)
        {
            int[,] resultMatrix = new int[n, n];
            int number = 1;

            int row = 0;
            int col = 0;
            DoRotateWalkWhilePossible(n, resultMatrix, ref number, ref row, ref col);

            FindCell(resultMatrix, out row, out col);
            if (row != 0 && col != 0)
            {
                DoRotateWalkWhilePossible(n, resultMatrix, ref number, ref row, ref col);
            }
            return resultMatrix;
        }

        private static void DoRotateWalkWhilePossible(int n, int[,] resultMatrix, ref int number, ref int row, ref int col)
        {
            int xDirection = 1;
            int yDirection = 1;

            while (true)
            {
                resultMatrix[row, col] = number;
                if (!CheckDirections(resultMatrix, row, col))
                {
                    break;
                }

                if (row + xDirection >= n || row + xDirection < 0 || col + yDirection >= n || col + yDirection < 0 || resultMatrix[row + xDirection, col + yDirection] != 0)
                {
                    while ((row + xDirection >= n || row + xDirection < 0 || col + yDirection >= n || col + yDirection < 0 || resultMatrix[row + xDirection, col + yDirection] != 0))
                    {
                        ChangeDirections(ref xDirection, ref yDirection);
                    }
                }

                row += xDirection;
                col += yDirection;
                number++;
            }
        }
    }
}
