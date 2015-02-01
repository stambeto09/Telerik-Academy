using System;
class MaximalSequence
{
    /*Write a program that finds the maximal sequence of equal elements in an array.
        Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int start = 0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 1;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            int j = i;
            start = arr[j];
            len = 1;
            while (j < (n - 1) && arr[j] == arr[j + 1])
            {
                len++;
                j++;
            }
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = start;
            }
        }
        Console.Write("{");
        for (int i = 0; i < bestLen; i++) Console.Write(bestStart + " ");
        Console.Write("}");
    }
}