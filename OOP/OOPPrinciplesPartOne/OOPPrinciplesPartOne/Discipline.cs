using System;
using System.Linq;

namespace OOPPrinciplesPartOne
{
    public class Discipline:ICommentable
    {
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;
        private string comments;

        public string Name 
        { 
            get
            {
                return this.name;
            } 
            set
            {
                if (value==string.Empty)
                {
                    throw new ArgumentNullException("Please, enter a valid name!");
                }
                else
                {
                    this.name = value;
                }
            }

        }

        public uint NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set 
            {
                this.numberOfLectures = value;
            }
        }

        public uint NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
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

        public Discipline()
        {
        }

        public Discipline(string name):this()
        {
            this.Name = name;
        }

        public Discipline(string name, uint numberOfLectures):this(name)
        {
            this.NumberOfLectures = numberOfLectures;
        }

        public Discipline(string name, uint numberOfLectures, uint numberOfExercises)
            : this(name, numberOfLectures)
        {
            this.NumberOfExercises = numberOfExercises;
        }


        

    }
}
