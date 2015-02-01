
namespace ComponentTestingHomework
{
    using System.Collections.Generic;
    using System;

    public class Course
    {
        private IList<Student> listOfStudents = new List<Student>();

        public IList<Student> ListOfStudents
        {
            get
            {
                return this.listOfStudents;
            }
            set
            {
                if (value.Count > 30)
                {
                    throw new ArgumentOutOfRangeException("The list of students should be less or 30.");
                }
            }

        }
    }
}
