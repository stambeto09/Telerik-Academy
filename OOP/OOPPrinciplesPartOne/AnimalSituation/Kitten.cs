using System;
using System.Linq;

namespace AnimalSituation
{
    public class Kitten : Cat
    {
        private const string Sex="Female";

        public Kitten()
        {
        }

        public Kitten(string name, uint age):base(name, Sex, age)
        {
        }

    }
}
