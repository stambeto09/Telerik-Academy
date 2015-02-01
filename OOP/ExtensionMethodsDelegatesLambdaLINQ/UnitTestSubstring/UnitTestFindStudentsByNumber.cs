using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ExtensionMethods;
using System.Collections.Generic;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestFindStudentsByNumber
    {
        [TestMethod]
        public void TestFindStudentsByNumber()
        {
            var students = new[]
            {
                new Student("Ivan", "Ivanov",15,1),
                new Student("Peter", "Stoianov",21,1),
                new Student("Ani", "Milenova",36,2),
                new Student("Zlatka", "Petrova",56,2),
                new Student("Gosho", "Tapoto",13,3),
                new Student("Pesho", "Peshev",41,1),
                new Student("Pesho", "Atanasov",18,1),
            };

            List<Student> listOfStudents = new List<Student>();
            foreach (var student in students)
            {
                listOfStudents.Add(student);
                //Console.WriteLine("{0} {1}",student.FirstName,student.SecondName);
            }

            List < Student > listWithNumberTwo = listOfStudents.FindAll(student => student.GroupNumber==2);

            foreach (var student in listWithNumberTwo)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
            }
        }
    }
}
