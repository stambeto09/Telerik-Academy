namespace Homework.StrategyPattern
{
    class MainApp
    {
        // Much more like polymoprhism.
        static void Main()
        {
            Context context;

            // Three contexts following different strategies
            context = new Context(new Dog());
            context.ContextInterface();

            context = new Context(new Cat());
            context.ContextInterface();

            context = new Context(new Bird());
            context.ContextInterface();

        }
    }
}
