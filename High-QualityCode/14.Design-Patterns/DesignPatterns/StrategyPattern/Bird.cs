namespace Homework.StrategyPattern
{
    using System;

    public class Bird : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("PiPIII");
        }
    }
}
