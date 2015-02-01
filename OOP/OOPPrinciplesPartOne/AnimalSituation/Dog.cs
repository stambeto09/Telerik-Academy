using System;
using System.Linq;

namespace AnimalSituation
{
    public class Dog : Animal, ISound
    {

        public Dog(string name, string sex, uint age):base(name, sex, age)
        {

        }
        public void ProduceSound()
        {
            Console.Beep(37, 25000);
        }
    }
}
