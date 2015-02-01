using System;


    class SquareRootHandler
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            try
            {
                uint number=uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid Number");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid Number");
            }
            catch(OverflowException)
            {
                Console.Error.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
            
        }
    }

