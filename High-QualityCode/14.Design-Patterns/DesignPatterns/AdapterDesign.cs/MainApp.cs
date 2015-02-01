namespace Homework.AdapterDesign
{
    using System;

    class MainApp
    {
        static void Main()
        {
            // Create adapter and place a request 
            Target target = new Adapter();
            target.Request();

            // Wait for user 
            Console.Read();
        }
    }
}
