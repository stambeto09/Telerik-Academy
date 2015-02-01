using System;
using System.Linq;


namespace OOPPrinciplesPartOne
{
    public class Student:People,ICommentable
    {
        
        private string classNumber;

        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Please, enter a valid number");
                }
                else
                {
                    this.classNumber = value;
                }
            }
        }


        public Student(string name):base(name)
        {
            this.Name = name;
        }

        public Student(string name, string classNumber):base(name)
        {
            this.ClassNumber = classNumber;
        }


    }
}
