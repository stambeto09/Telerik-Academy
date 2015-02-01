using System;
using System.Linq;

namespace HumanSituation
{
    public class Student:Human
    {

        private uint grade;

        public uint Grade 
        { 
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public Student(string name):base(name)
        {
            this.FirstName = name;
        }

        public Student(string firstName, string lastName, uint grade):base(firstName,lastName)
        {
            this.Grade = grade;
        }
        
    }
}
