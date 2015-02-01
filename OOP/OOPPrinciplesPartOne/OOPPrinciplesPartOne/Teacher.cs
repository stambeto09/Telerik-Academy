using System;
using System.Collections.Generic;

namespace OOPPrinciplesPartOne
{
    public class Teacher:People,ICommentable
    {
        private string teacherName;
        private List<Discipline> disciplines;

        public string TeacherName 
        { 
            get
            {
                return this.teacherName;
            }
            set
            {
                if (value==string.Empty)
                {
                    throw new ArgumentNullException("Please, enter a valid name!");
                }
                else
                {
                    this.teacherName = value;
                }
                
            }
        }

        public Teacher(string teacherName):base(teacherName)
        {
            this.TeacherName = teacherName;
        }

        public Teacher(string teacherName, List<Discipline> listOfDisciplines)
            : base(teacherName)
        {
            this.Disciplines = listOfDisciplines;
        }

        public List<Discipline> Disciplines 
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            if (discipline==null)
            {
                throw new ArgumentException("The discipline cannot be empty!");
            }
            else
            {
                this.disciplines.Add(discipline);
            }
           
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (discipline==null)
            {
                throw new ArgumentException("The discipline can not be empty!");
            }
            else
            {
                this.disciplines.Remove(discipline);
            }
        }
    }
}
