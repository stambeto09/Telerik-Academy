using System;
using System.Linq;

namespace AnimalSituation
{
    public class Cat : Animal, ISound
    {
        public Cat()
        {

        }

        public Cat(string name):base(name)
        {  
        }

        public Cat(string name, string sex):base(name, sex)
        {
        }

        public Cat(string name, string sex, uint age):base(name, sex, age)
        { 
        }

        public void ProduceSound()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
            }
        }
    }
}
