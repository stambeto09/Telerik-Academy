namespace Homework.StrategyPattern
{
    using System;

    public class Cat : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Miay");
        }
    }
}
