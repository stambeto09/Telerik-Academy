using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestEmailAndPhone
    {
        [TestMethod]
        public void TestMethodExtractPersonsWithAbvMailAndPhone()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Pesho","Peshev",15,1,"pesho@abv.bg","02876455",new List<int> {3, 4},"123406"),
                new Student("Georgi","Kostadinov",18,3,"georgi@gmail.com","12876455",new List<int> {6, 5, 6, 6},"123456"),
                new Student("Doncho","Minkov",23,2,"Doncho@yahoo.com","03876455", new List<int> {6, 5, 6},"123456"),
                new Student("Svetlin","Nakov",30,2,"Svetlin@nakov.com","52876455", new List<int> {6, 6},"261606"),
                new Student("Stanimir","Bazalov",6,3,"Stanimir@abv.bg","039176455", new List<int>{2, 2, 3, 3},"123456"),
                new Student("Ioana","Georgieva",38,4,"Ioana@abv.bg","612126455", new List<int> {2, 2, 3, 3, 4},"123456",new Group("Chemistry")),
            };

            var personsWithAbv =
                from person in listOfStudents
                where person.Email.EndsWith("@abv.bg")
                select person;

            foreach (var student in personsWithAbv)
            {
                Console.WriteLine("{0} {1}",student.FirstName, student.SecondName);
            }
            Console.WriteLine();

            var personsWithSofiaPhone =
                from person in listOfStudents
                where person.Telephone.StartsWith("02")
                select person;

            foreach (var student in personsWithSofiaPhone)
            {
                Console.WriteLine("{0} {1}",student.FirstName, student.SecondName);
            }

            var personsWithMarkSix=
                from person in listOfStudents
                where person.GetMark(6)
                select new { FullName = person.FirstName + " " + person.SecondName, Marks = person.GetMarks() };

            Console.WriteLine();
            foreach (var student in personsWithMarkSix)
            {
                Console.WriteLine("{0} {1}",student.FullName,student.Marks);   
            }

            var personsWithTwoMarks=
                from person in listOfStudents
                where person.GetTwoMarks(2)
                select new { FullName = person.FirstName + " " + person.SecondName, Marks = person.GetMarks() };
            Console.WriteLine();

            foreach (var student in personsWithTwoMarks)
            {
                Console.WriteLine("{0}", student.FullName);
            }

            var studentsEnrolledAt2006=
                from student in listOfStudents
                where student.FacultyNumber.EndsWith("06")
                select  new { FullName = student.FirstName + " " + student.SecondName, FacultyNumber = student.GetFacultyNumber() };
            Console.WriteLine();

            foreach (var student in studentsEnrolledAt2006)
            {
                Console.WriteLine("{0} {1} ", student.FullName, student.FacultyNumber);
            }

            //var studentsFromMathDep=
            //    from student in listOfStudents 
            //    where student.CheckStudentDepartment(student)
            //    select new { FullName = student.FirstName + " " + student.SecondName, DepartmentName = student.GetStudentDepartment() };

            //Console.WriteLine();
            //foreach (var student in studentsFromMathDep)
            //{
            //    Console.WriteLine("{0} {1} ", student.FullName, student.DepartmentName);
            //}
        
        
        }

    }
}
