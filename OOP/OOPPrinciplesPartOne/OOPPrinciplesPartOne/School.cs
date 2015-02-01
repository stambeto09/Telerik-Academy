using System;
using System.Linq;



namespace OOPPrinciplesPartOne
{
   
    public class School
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please enter a valid school name!");
                }
                else
                {
                    this.name = value;
                }
            }

            
        }
    }
}
