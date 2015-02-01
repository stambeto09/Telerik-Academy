using System;
using System.Linq;

namespace AnimalSituation
{
    public class Tomcat : Cat
    {
        private const string Sex = "Male";

        public Tomcat(string name, uint age):base(name, Sex, age)
        {
        }
    }
}
