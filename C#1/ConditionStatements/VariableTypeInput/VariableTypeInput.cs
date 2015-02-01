using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTypeInput
{
    class VariableTypeInput
    {
        static void Main()
        {
            Console.Write("Enter a type for variable: ");
            string type = Console.ReadLine();
            switch (type)
            {
                case ("integer"): Console.Write("Enter a integer value: ");
                    int intValue=int.Parse(Console.ReadLine());
                    Console.WriteLine("The integer value increased by one is equal to {0}",intValue+1);break;
                case ("double"): Console.Write("Enter a double value: ");
                    double doubleValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("The double value increased by one is equal to {0}", doubleValue+1); break;
                case ("string"): Console.Write("Enter a string value: ");
                    string stringValue = Console.ReadLine();
                    Console.WriteLine(stringValue+"*");break;


                
            }
        }
    }
}
