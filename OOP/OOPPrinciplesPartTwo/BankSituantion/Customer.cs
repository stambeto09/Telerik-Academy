using System;
using System.Linq;

namespace BankSituantion
{
    public abstract class Customer
    {

        private string name;
        private string egn;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Please, enter a valid name");
                }

                this.name = value;
            }
        }

        public string EGN
        {
            get
            {
                return this.egn;
            }
            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Please, enter a valid EGN!");
                }

                this.egn = value;
            }
        }
    }
}
