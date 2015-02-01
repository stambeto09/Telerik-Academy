using System;
using System.Text;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse() 
        {

        }

        public LocalCourse(string name) : base(name)
        {

        }

        public LocalCourse(string name, string teacherName) : base(name, teacherName)
        {

        }

        public LocalCourse(string name, string teacherName, List<string> students) : 
            base(name, teacherName, students)
        {

        }

        public LocalCourse(string name, string teacherName, List<string> students, string lab) :
            base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab 
        { 
            get
            {
                return this.lab;
            }
            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return base.ToString() + result.ToString();
        }
    }
}

