using System;
using System.Collections.Generic;
namespace Phone
{
    public class Test
    {
        public static MobilePhone[] IntializeArray(int arrayLength,MobilePhone [ ]phonesArray)
        {
            for (int index = 0; index < phonesArray.Length; index++)
            {
                Console.Write("Enter the name of the owner # {0}:", index + 1);
                string currentNameOwner = Console.ReadLine();
                Console.Write("Enter a manufacturer of the phone #{0}", index + 1);
                string currentManufacturer = Console.ReadLine();
                Console.Write("Enter a model of the phone #{0}", index + 1);
                string currentModel = Console.ReadLine();
                Console.Write("Enter a price of the phone #{0}", index + 1);
                decimal currentPrice = decimal.Parse(Console.ReadLine());
                phonesArray[index] = new MobilePhone(currentModel, currentManufacturer, currentPrice, currentNameOwner);
            }
            return phonesArray;
        }

        public static void PrintIphoneSpec()
        {
            Console.WriteLine();
            MobilePhone iPhone = MobilePhone.Iphone4s;
            iPhone.Name = "Pesho";
            Console.WriteLine(iPhone.ToString());
        }
        static void Main()
        {
            Console.Write("How many phone you want to validate? ");
            int numberOfPhones=int.Parse(Console.ReadLine());
            MobilePhone[] arrayOfPhones = new MobilePhone[numberOfPhones];
            MobilePhone[] newArrayOfPhones=IntializeArray(numberOfPhones, arrayOfPhones);

            for (int index = 0; index < arrayOfPhones.Length; index++)
            {
                Console.WriteLine();
                Console.WriteLine("Phone #{0}",index+1);
                Console.WriteLine("Model:{0}", arrayOfPhones[index].Model);
                Console.WriteLine("Manufacturer:{0}",arrayOfPhones[index].Manufacturer);
                Console.WriteLine("Name:{0}", arrayOfPhones[index].Name);
                Console.WriteLine("Price:{0}", arrayOfPhones[index].Price);
            }

            PrintIphoneSpec();

           

        }
        
    }
}