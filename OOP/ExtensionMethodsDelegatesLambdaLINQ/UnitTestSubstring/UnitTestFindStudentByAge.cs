using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ExtensionMethods;

namespace UnitTestSubstring
{
    [TestClass]
    public class UnitTestFindStudentByAge
    {
        [TestMethod]
        public void FindStudentsByAge()
        {
            Student[] students = new[]
            {
                new Student("Ivan", "Ivanov",15),
                new Student("Peter", "Stoianov",21),
                new Student("Ani", "Milenova",36),
                new Student("Zlatka", "Petrova",56),
                new Student("Gosho", "Tapoto",13),
                new Student("Pesho", "Peshev",41),
                new Student("Pesho", "Atanasov",18),
            };

            var studentInInterval18To24 =
                from student in students
                where student.Age >= 18 || student.Age <= 24
                select student.FirstName;

            foreach (string student in studentInInterval18To24)
            {
                Console.WriteLine(student);
            }
        }
    }
}
