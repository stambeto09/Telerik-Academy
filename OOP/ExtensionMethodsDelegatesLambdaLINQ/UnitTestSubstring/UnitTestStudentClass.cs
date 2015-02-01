using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestStudentClass
    {
        [TestMethod]
        public void TestStudentClass()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Pesho","Peshev",15,1),
                new Student("Georgi","Kostadinov",18,3),
                new Student("Doncho","Minkov",23,2),
                new Student("Svetlin","Nakov",30,2),
                new Student("Stanimir","Bazalov",6,3),
                new Student("Ioana","Georgieva",38,4),
            };

            var personsFromSecondGroup =
                from person in listOfStudents
                where person.GroupNumber == 2
                select person;

            var sortedPersonsFromSecondGroup = personsFromSecondGroup.OrderBy(person => person.FirstName);

            foreach (var person in sortedPersonsFromSecondGroup)
            {
                Console.WriteLine("{0} {1}",person.FirstName, person.SecondName);
            }

            
        }
    }
}
