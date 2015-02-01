using System;
using System.Linq;

namespace CommonTypeSystem
{
    class MainClass
    {
        public static void Main()
        {
            Student firstStudent = new Student();
            firstStudent.Name = "Pesho";
            firstStudent.MiddleName = "Peshev";
            firstStudent.LastName = "Pesheto";
            firstStudent.SSN = "123456789";
            firstStudent.MobilePhone = "1234567890";
            firstStudent.Email = "akapesheto@gmail.com";
            firstStudent.Address = "Chetvurti kilometur";
            firstStudent.Course = "OOP";
            Console.WriteLine(firstStudent.ToString());

        }
    }
}
