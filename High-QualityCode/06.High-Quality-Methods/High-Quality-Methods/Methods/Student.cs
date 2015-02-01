using System;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string additionalInformation;
          
        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if ((value == string.Empty) || (value.Length < 2))
                {
                    throw new ArgumentException("The first name is too short.");
                }
                this.firstName = value;
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
                if ((value == string.Empty) || (value.Length < 2))
                {
                    throw new ArgumentException("The last name is too short.");
                }
                this.lastName = value;
            }
        }

        public string AdditionalInformation 
        { 
            get
            {
                return this.additionalInformation;
            }
            set
            {
                this.additionalInformation = value;
            }
        }

        public bool CompareByDateOfBirth(Student otherStudent)
        {
            DateTime ourStudentBirthDate =
                DateTime.Parse(this.AdditionalInformation.Substring(this.AdditionalInformation.Length - 10));
            DateTime otherStudentBirthDate =
                DateTime.Parse(otherStudent.AdditionalInformation.Substring(otherStudent.AdditionalInformation.Length - 10));

            bool isOlderThanOtherStudent = ourStudentBirthDate > otherStudentBirthDate;
            return isOlderThanOtherStudent;
        }
    }
}
