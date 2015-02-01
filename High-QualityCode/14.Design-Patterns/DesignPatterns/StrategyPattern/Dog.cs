namespace Homework.StrategyPattern
{
    using System;

    public class Dog : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Bay");
        }
    }
}
