using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;
using System.Linq;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestStudentsSorting
    {
        [TestMethod]
        public void TestStudentsSorting()
        {
            Student[] students = new[]
            {
                new Student("Ivan", "Ivanov"),
                new Student("Peter", "Stoianov"),
                new Student("Ani", "Milenova"),
                new Student("Zlatka", "Petrova"),
                new Student("GOsho", "Tapoto"),
                new Student("Pesho", "Peshev"),
                new Student("Pesho", "Atanasov"),
            };

            var sortedStudents = students.OrderBy(student => student.FirstName).ThenBy(student => student.SecondName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.SecondName);
            }
        }
    }
}
