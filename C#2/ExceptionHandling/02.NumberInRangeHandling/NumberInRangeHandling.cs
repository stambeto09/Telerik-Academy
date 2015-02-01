using System;


    class NumberInRangeHandling
    {
        static void ReadNumber(int start, int end)
        {
            for (int index  = 0; index < 10; index++)
            {
                Console.Write("Enter a number: ");
                
                try
                {
                    int number = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("The number is not in the right format!");
                }
                catch(ArgumentNullException)
                {
                    Console.Error.WriteLine("Invalid number!");
                }
            }
            

        }
        static void Main()
        {
            Console.Write("Enter a number for start of the interval: ");
            int startInterval = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for end of the interval: ");
            int endInterval = int.Parse(Console.ReadLine());
            ReadNumber(startInterval,endInterval);


        }
    }
