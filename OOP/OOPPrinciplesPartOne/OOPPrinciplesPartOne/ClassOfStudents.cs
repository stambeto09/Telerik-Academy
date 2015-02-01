using System;
using System.Collections.Generic;
using System.Linq;


namespace OOPPrinciplesPartOne
{
    public class ClassOfStudents:School,ICommentable
    {
        private string textIdentifier;
        private List<Teacher> listOfTeachers;
        private string comments;

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("Please, enter a value identifier!");
                }
                else
                {
                    this.textIdentifier = value;
                }
            }
                
        }

        public List<Teacher> ListOfTeachers
        {
            get
            {
                return this.listOfTeachers;
            }
            set
            {
                this.listOfTeachers = value;
            }
        }

        public ClassOfStudents()
        {

        }

        public ClassOfStudents(string textIentifier):this()
        {
            this.TextIdentifier = textIentifier;
        }

        public ClassOfStudents(string textIentifier,string comments)
            : this(textIentifier)
        {
            this.Comments = comments;
        }

        public ClassOfStudents(string textIentifier, string comments, List<Teacher> listOfTeachers)
            : this(textIentifier,comments)
        {
            this.ListOfTeachers = listOfTeachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            listOfTeachers.Add(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            listOfTeachers.Remove(teacher);
        }

        public string Comments
        {
            get
            {
                if (this.comments == null)
                {
                    return "No comments yet";
                }

                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }
    }

}
