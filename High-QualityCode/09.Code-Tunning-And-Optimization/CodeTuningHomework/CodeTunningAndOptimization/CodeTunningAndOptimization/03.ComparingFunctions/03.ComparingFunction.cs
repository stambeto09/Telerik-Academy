using System;
using System.Linq;
using System.Diagnostics;

namespace _03.ComparingFunctions
{
    class ComparingFunctions
    {
        static void Main()
        {
            float floatNumber = 10f;
            double doubleNumber = 10d;
            decimal decimalNumber = 10m;

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Math.Sqrt()");
            Console.WriteLine("You can't use Math.Sqrt() on decimal number. :)");
            stopwatch.Start();
            Math.Sqrt(doubleNumber);
            stopwatch.Stop();
            Console.WriteLine("Double: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            Math.Sqrt(floatNumber);
            stopwatch.Stop();
            Console.WriteLine("Float: {0}", stopwatch.Elapsed);

            Console.WriteLine("Natural Logarithm.");
            Console.WriteLine("You can't use Math.Log10() on decimal number.");
            stopwatch.Start();
            Math.Log10(doubleNumber);
            stopwatch.Stop();
            Console.WriteLine("Double: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            Math.Log10(floatNumber);
            stopwatch.Stop();
            Console.WriteLine("Float: {0}", stopwatch.Elapsed);

            Console.WriteLine("Sine");
            Console.WriteLine("You can't use Math.Sin() on decimal number.");
            stopwatch.Start();
            Math.Sin(doubleNumber);
            stopwatch.Stop();
            Console.WriteLine("Double: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            Math.Sin(floatNumber);
            stopwatch.Stop();
            Console.WriteLine("Float: {0}", stopwatch.Elapsed);

        }
    }
}
