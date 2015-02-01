using System;
using System.Linq;
using System.Diagnostics;

namespace CodeTunningAndOptimization
{
    class ComparingPrimitiveTypes
    {
        static void Main()
        {
            Console.WriteLine("Integer type:");

            Console.Write("Increment: ");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int intTest = int.MinValue;
            for (int i = 0; i < 10000; i++)
            {
                intTest++;
            }
            stopwatch.Stop();
            intTest = int.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Sum: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                intTest += 1000;
            }
            stopwatch.Stop();
            intTest = int.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();


            Console.Write("Substract: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                intTest -= 2;
            }
            stopwatch.Stop();
            intTest = int.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Multiply: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                intTest *= 2;
            }
            stopwatch.Stop();
            intTest = int.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Divide: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                intTest /= 2;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Long type:");

            Console.Write("Increment: ");
            stopwatch.Start();
            long longTest = long.MinValue;
            for (int i = 0; i < 10000; i++)
            {
                longTest++;
            }
            stopwatch.Stop();
            longTest = long.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Sum: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                longTest += 1000;
            }
            stopwatch.Stop();
            longTest = long.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();


            Console.Write("Substract: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                longTest -= 2;
            }
            stopwatch.Stop();
            longTest = long.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Multiply: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                longTest *= 2;
            }
            stopwatch.Stop();
            longTest = long.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Divide: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                longTest /= 2;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Float type:");

            Console.Write("Increment: ");
            stopwatch.Start();
            float floatType = float.MinValue;
            for (int i = 0; i < 10000; i++)
            {
                floatType++;
            }
            stopwatch.Stop();
            floatType = float.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Sum: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                floatType += 1000;
            }
            stopwatch.Stop();
            floatType = float.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();


            Console.Write("Substract: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                floatType -= 2;
            }
            stopwatch.Stop();
            floatType = float.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Multiply: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                floatType *= 2;
            }
            stopwatch.Stop();
            floatType = float.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Divide: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                floatType /= 2;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Double type:");

            Console.Write("Increment: ");
            stopwatch.Start();
            double doubleType = double.MinValue;
            for (int i = 0; i < 10000; i++)
            {
                floatType++;
            }
            stopwatch.Stop();
            doubleType = double.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Sum: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                doubleType += 1000;
            }
            stopwatch.Stop();
            doubleType = double.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();


            Console.Write("Substract: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                doubleType -= 2;
            }
            stopwatch.Stop();
            doubleType = double.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Multiply: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                doubleType *= 2;
            }
            stopwatch.Stop();
            doubleType = double.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Divide: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                doubleType /= 2;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Decimal type:");

            Console.Write("Increment: ");
            stopwatch.Start();
            decimal decimalType = decimal.MinValue;
            for (int i = 0; i < 10000; i++)
            {
                decimalType++;
            }
            stopwatch.Stop();
            decimalType = decimal.MinValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Sum: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                decimalType += 1000;
            }
            stopwatch.Stop();
            decimalType = decimal.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();


            Console.Write("Substract: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                decimalType -= 2;
            }
            stopwatch.Stop();
            decimalType = 0.1m;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Multiply: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                decimalType *= 0.9m;
            }
            stopwatch.Stop();
            decimalType = decimal.MaxValue;
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            Console.Write("Divide: ");
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                decimalType /= 2;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}
