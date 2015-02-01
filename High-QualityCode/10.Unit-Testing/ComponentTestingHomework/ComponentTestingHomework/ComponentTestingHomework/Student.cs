
namespace ComponentTestingHomework
{
    using System;
    using System.Collections.Generic;
    public class Student
    {
        private string name;
        private int number;
        private IList<Course> listOfCourses;

        public IList<Course> ListOfCourses
        {
            get
            {
                return this.listOfCourses;
            }
            set
            {
                this.listOfCourses = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name can't be empty.", "name");
                }
                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if ((value < 10000) || (value > 99999))
                {
                    throw new ArgumentOutOfRangeException("The student number must be in interval between 10 000 and 99 999.", "number");
                }
                this.number = value;
            }
        }

        public void LeaveCourse(Course course)
        {
            this.ListOfCourses.Remove(course);
        }

        public void AddCourse(Course course)
        {
            this.ListOfCourses.Add(course);
        }

    }
}
