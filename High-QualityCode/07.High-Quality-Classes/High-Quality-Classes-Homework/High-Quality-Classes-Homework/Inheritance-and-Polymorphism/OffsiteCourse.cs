using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse() 
        {

        }

        public OffsiteCourse(string name) : base(name)
        {

        }

        public OffsiteCourse(string name, string teacherName) : base(name, teacherName)
        {

        }

        public OffsiteCourse(string name, string teacherName, List<string> students) : 
            base(name, teacherName, students)
        {

        }

        public OffsiteCourse(string name, string teacherName, List<string> students, string town) :
            base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name of the city is too short", "town");
                }
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return base.ToString() + result.ToString();
        }
    }
}
