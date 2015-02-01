using System;
using System.Linq;
using System.Collections.Generic;

namespace AnimalSituation
{
    class Program
    {
        static void Main()
        {
            Animal[] arrOfAnimals = new Animal[4]
            {
                new Tomcat("Tom",13),
                new Frog("Frog", "Male", 15),
                new Kitten("Nyan",20),
                new Dog("Dog","Male",15),
            };
            

            Console.WriteLine("The average age of animals is: {0}", Animal.Average(arrOfAnimals));

            
        }


    }
}
