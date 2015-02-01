using System;
using System.Linq;


namespace OOPPrinciplesPartOne
{
    public abstract class People:ICommentable
    {
        private string comments;
        private string name;


        public string  Name
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, enter a valid name!");
                }
                else
                {
                    this.name = value;
                }
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

        public People(string name)
        {
            this.Name = name;
        }
    }
}
