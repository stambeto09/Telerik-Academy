using System;
using System.Linq;


namespace AnimalSituation
{
    public abstract class Animal
    {
        private uint age;
        private string name;
        private string sex;

        public  uint Age
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

        public  string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, enter a valid name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                if (value==null || value.Length<4)
                {
                    throw new ArgumentException("Please enter a valid sex!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }

        public Animal()
        {

        }

        public Animal(string name):this()
        {
            this.Name = name;
        }

        public Animal(string name, string sex):this(name)
        {
            this.Sex = sex;
        }

        public Animal(string name, string sex, uint age):this(name, sex)
        {
            this.Age = age;
        }

        public static double Average(Animal [] array)
        {
            double averageAge = 0;
            double sumOfAges = 0;

            foreach (Animal animal in array)
            {
                sumOfAges += animal.Age;
            }

            averageAge = sumOfAges / array.Length;

            return averageAge;
        }
    
    }
}
