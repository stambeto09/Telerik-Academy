using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.VariationsOfKElements
{
    class VariationsOfKElements
    {
        //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N];
        static int NumberOfLoops;
        static int NumberOfIterations;
        static int[] Loops;
        static void Main(string[] args)
        {
             Console.Write("N:");
        NumberOfIterations = int.Parse(Console.ReadLine());
 
        Console.Write("K:");
        NumberOfLoops = int.Parse(Console.ReadLine());
             
        Loops = new int[NumberOfLoops];
 
        NestedLoops(0);
    }
 
    static void NestedLoops(int CurrentLoop)
    {
        if (CurrentLoop == NumberOfLoops)
        {
            PrintLoops();
            return;
        }
        for (int i = 1; i <=NumberOfIterations; i++)
        {
            Loops[CurrentLoop] = i;
            NestedLoops(CurrentLoop+1);
        }
    }
 
    static void PrintLoops()
    {
        for (int i = 0; i < NumberOfLoops; i++)
        {
            Console.Write("{0} ",Loops[i]);
        }
        Console.WriteLine();
    }
        }
    
}
