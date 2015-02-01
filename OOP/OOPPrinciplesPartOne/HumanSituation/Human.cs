using System;
using System.Linq;

namespace HumanSituation
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }
            set
            {
                if ((value==null) || (value.Length<2))
                {
                    throw new ArgumentException("Please enter a valid name!");
                }
                else
                {
                    this.firstName = value;
                }

            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if ((value==null) || (value.Length<2))
                {
                    throw new ArgumentException("Please, enter a valid name!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public Human()
        {
        }

        public Human(string firstName):this()
        {
            this.FirstName = firstName;
        }

        public Human(string firstName, string lastName):this(firstName)
        {
            this.LastName = lastName;
        }

    }
    
}
