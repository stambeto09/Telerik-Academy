using System;
using System.Linq;

namespace AnimalSituation
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, string sex, uint age):base(name, sex, age)
        {

        }
        public void ProduceSound()
        {
            Console.Beep(370, 15000);
        }
    }
}
