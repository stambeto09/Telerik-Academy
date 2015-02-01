using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtensionMethods
{
    public class Student
    {
        private string firstName;
        private string secondName;
        private uint age;
        private string facultyNumber;
        private string telephone;
        private string email;
        private List<int> marks;
        private uint groupNumber;
        private Group studentGroup;

        public Group StudentGroup
        {
            get
            {
                return this.studentGroup;
            }
            set
            {
                    this.studentGroup = value;
            }
        }

       

        public uint GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }
        public List<int> Marks
        {
            get { return this.marks; }
        }

        public int MarksCount
        {
            get
            {
                return this.marks.Count;
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
                this.email = value;
            }
        }

        public string Telephone
        {
            get
            {
                return this.telephone;
            }
            set
            {
                this.telephone = value;
            }
        }
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }

        public uint Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value==0)
                {
                    throw new ArgumentException("The age can not be 0!");
                }
                else
                {
                  this.age = value;
                }
            }
        }
        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string SecondName 
        { 
            get
            {
                return this.secondName;
            }
            set
            {
                this.secondName = value;
            }
        }
        
        public Student(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public Student(string firstName, string secondName, uint age):this(firstName,secondName)
        {
            this.Age = age;
        }
        public Student(string firstName, string secondName, uint age, uint groupNumber)
            : this(firstName, secondName,age)
        {
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string secondName, uint age, uint groupNumber, string email)
            : this(firstName, secondName, age, groupNumber)
        {
            this.Email = email;          
        }
        public Student(string firstName, string secondName, uint age, uint groupNumber, string email,string phone)
            : this(firstName, secondName, age, groupNumber, email)
        {
            this.Telephone = phone;
        }

        public Student(string firstName, string secondName, uint age, uint groupNumber, string email, string phone,List<int> marks)
            : this(firstName, secondName, age, groupNumber, email, phone)
        {
            this.marks = marks;
        }

        public Student(string firstName, string secondName, uint age, uint groupNumber, string email, string phone, List<int> marks, string facultyNumber)
            : this(firstName, secondName, age, groupNumber, email, phone, marks)
        {
            this.FacultyNumber = facultyNumber;
        }
        public Student(string firstName, string secondName, uint age, uint groupNumber, string email, string phone, List<int> marks, string facultyNumber, Group studentGroup)
            : this(firstName, secondName, age, groupNumber, email, phone, marks)
        {
            this.studentGroup = studentGroup;
        }
        
        public Student()
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
            this.GroupNumber = groupNumber;
            this.Email = email;
        }

        public static Student[] FindAllStudentWithFirstNameGreater(List<Student> studentList)
        {
            var sievedList =
                from student in studentList
                where student.FirstName.CompareTo(student.SecondName) < 0
                select student;

            Student[] studentResultArray = new Student[sievedList.Count()];

            foreach (Student student in studentResultArray)
            {
                Console.WriteLine("{0} + {1}", student.FirstName,student.SecondName);
            }
            return studentResultArray;
        }

        public bool GetMark(int mark)
        {
            return this.marks.Contains(mark);
        }

        public bool GetTwoMarks(int mark)
        {
            int counter = 0;
            foreach (var number in marks)
            {
                if (number==mark)
                {
                    counter++;
                }
            }
            if (counter==2)
            {
                return true;
            }
            return false;
        }

        public string GetFacultyNumber()
        {
            return FacultyNumber.ToString();
            
        }
        public string GetMarks()
        {
            return string.Join(", ",this.marks);
        }

        public bool CheckStudentDepartment(Student currentStudent)
        {
            if (currentStudent.studentGroup.DepartmentName=="Math")
            {
                return true;
            }
            return false;
        }

        public string GetStudentDepartment()
        {
            return studentGroup.DepartmentName;
        }

        
    }
}
