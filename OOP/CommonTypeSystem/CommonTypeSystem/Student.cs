using System;
using System.Linq;
using System.Text;

namespace CommonTypeSystem
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string name;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private string course;
        enum Universities { Sofia , Technical , Unss };
        enum Faculties { FKSU, FMI, FI, EF };
        enum Specialties { Telecommunications, Marketing, Business, Informatics, Law, Philosophy };

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please enter a valid name.");
                }

                this.name = value;  
            }
        }

        public string  MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please enter a valid middle name!");
                }
                this.middleName = value;
            }


        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, enter a valid last name!");
                }
                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                if (value.Length!=9)
                {
                    throw new ArgumentException("Please, enter a valid SSN!");
                }
                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, enter a valid address!");
                }
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, enter a valid mobile number!");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, enter a valid email address!");
                }
                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, enter a valid name of the course! ");
                }
                this.course = value;
            }
        }

        public Student()
        {
        }

        public Student(string name, string middleName, string lastName):this()
        {
            this.LastName = lastName;
            this.Name = name;
            this.MiddleName = middleName;
        }

        public Student(string name, string middleName, string lastName, string ssn, string address)
            :this(name, middleName, lastName)
        {
            this.SSN = ssn;
            this.Address = address;
        }

        public Student(string name, string middleName, string lastName, string ssn, string address, string mobilePhone, string email, string course)
            :this(name, middleName, lastName, ssn, address)
        {
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
        }

        public override bool Equals(object student)
        {
            Student newStudent = student as Student;

            if (this.Name==newStudent.Name)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Name+" ");
            sb.Append(this.MiddleName + " ");
            sb.AppendLine(this.LastName);
            sb.AppendLine("SSN: " + this.SSN);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Mobile phone: " + this.MobilePhone);
            sb.AppendLine("Email: " + this.Email );
            sb.AppendLine("Course: " + this.email );
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.LastName.GetHashCode() ^ this.MiddleName.GetHashCode() ;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if ((firstStudent.Name==secondStudent.Name) && (firstStudent.LastName==secondStudent.LastName))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if ((firstStudent.Name != secondStudent.Name) && (firstStudent.LastName != secondStudent.LastName))
            {
                return true;
            }

            return false;
        }

        public int CompareTo(Student comparedStudent)
        {
            if (this.Name != comparedStudent.Name)
            {
                return string.Compare(this.Name, comparedStudent.Name);
            }
            if (this.LastName != comparedStudent.LastName)
            {
                return string.Compare(this.Name, comparedStudent.Name);
            }
            if (this.SSN != comparedStudent.SSN)
            {
                return string.Compare(this.SSN, comparedStudent.Name);
            }
            return 0;
        }

        public object Clone()
        {
            Student clonedStudent = new Student();
            clonedStudent.Name = this.Name;
            clonedStudent.LastName = this.LastName;
            clonedStudent.MiddleName = this.MiddleName;
            clonedStudent.SSN = this.SSN;
            clonedStudent.Address = this.Address;
            clonedStudent.MobilePhone = this.MobilePhone;
            clonedStudent.Email = this.Email;
            clonedStudent.Course = this.Course;

            return clonedStudent;
        }

        
    }
}
