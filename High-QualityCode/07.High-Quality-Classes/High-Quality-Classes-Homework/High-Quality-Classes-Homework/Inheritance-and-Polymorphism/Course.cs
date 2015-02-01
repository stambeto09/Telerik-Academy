using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course() { }

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, string teacherName) : this(name)
        {
            this.TeacherName = teacherName;
        }

        public Course(string name, string teacherName, List<string> students)
            : this(name, teacherName)
        {
            this.Students = students;
        }

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
                    throw new ArgumentException("The course name must be more than 2 digits long.", "name");
                }
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                //if (value.Length < 2)
                //{
                //    throw new ArgumentException("The teacher name must be mora than 2 digits long", "teacherName");
                //}
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append(" { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }

    }
}
