using System;

namespace Homework.StrategyPattern
{
    public class Context
    {
        private Strategy strategy;

        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
