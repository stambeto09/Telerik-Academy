using System;
using System.Linq;
using System.Text;

namespace CommonTypeSystem
{
    public class Person
    {
        private string name;
        private uint? age;

        public string  Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public uint? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name" + this.Name);
            if (this.Age==null)
            {
                sb.AppendLine("Your age is null.");
            }
            else
            {
                sb.AppendLine("Your age is" + this.Age);
            }

            return sb.ToString();
        } 


    }
}
