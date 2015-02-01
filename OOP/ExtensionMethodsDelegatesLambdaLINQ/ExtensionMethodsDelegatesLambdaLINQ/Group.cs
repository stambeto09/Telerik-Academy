using System;
using System.Linq;

namespace ExtensionMethods
{
    public class Group
    {
        private string groupNumber;
        private string departmentName;

        public string GroupNumber 
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value==string.Empty)
                {
                    throw new ArgumentNullException("Please, enter a valid group name!");
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        public string DepartmentName 
        {
            get
            {
                return this.departmentName;
            }
            set
            {
                if (value==string.Empty)
                {
                    throw new ArgumentNullException("Please, enter a valid department name!");
                }
                else
                {
                    this.departmentName = value;
                }
            }
        }

        public  Group()
        {
        }

        public Group(string departmentName) :this()
        {
            this.departmentName = departmentName;
        }

        public Group(string departmentName, string groupNumber) : this (departmentName)
        {
            this.groupNumber = groupNumber;
        }


    }
}
