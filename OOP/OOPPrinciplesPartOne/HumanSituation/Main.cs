using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanSituation
{
    class MainClass
    {
        static void Main()
        {
            Worker testWorker = new Worker("Pesho", "Peshev", 125, 14);
            Console.WriteLine(testWorker.FirstName);
            Console.WriteLine(testWorker.LastName);
            Console.WriteLine(testWorker.WeekSalary);
            Console.WriteLine(testWorker.WorkHoursPerDay);

            List<Student> listOfStudents = new List<Student>
            {
               new Student("Pesho","Peshev",6),
               new Student("Georgi","Georgiev",5),
               new Student("Avgustin","Septemvriiski",4),
               new Student("Stanimir","Qkimov",5),
               new Student("Ralica","Petrova",3),
               new Student("Ioana","Qnakieva",3)
            };

            var sortedStudentsByGrade = listOfStudents.OrderBy(student => student.Grade)
                .ThenBy(student => student.FirstName);

            foreach (var student in sortedStudentsByGrade)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName
                    , student.Grade);
            }
        }
    }
}
