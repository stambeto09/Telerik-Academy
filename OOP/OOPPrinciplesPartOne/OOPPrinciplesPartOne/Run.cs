using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPPrinciplesPartOne
{
    public class Test
    {
        static void Main()
        {
            Discipline math = new Discipline("Math", 100);
            Discipline biology = new Discipline("Biology", 20);

            List<Discipline> listOfDisciplines= new List<Discipline>{math,biology};

            Teacher Milka = new Teacher("Milka", listOfDisciplines);
            Teacher Boncho = new Teacher("Boncho", listOfDisciplines);
            List<Teacher> listOfTeachers = new List<Teacher> { Milka, Boncho };
            ClassOfStudents newClass = new ClassOfStudents("TextIdentifier","No comment",listOfTeachers);
            Student ivancho = new Student("Ivancho");
            Student veronika = new Student("Veronika");

        }
    }
}
