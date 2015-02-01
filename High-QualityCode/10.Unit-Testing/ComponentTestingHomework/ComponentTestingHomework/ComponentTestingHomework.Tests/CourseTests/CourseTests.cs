using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComponentTestingHomework;
using System.Collections.Generic;

namespace ComponentTestingHomework.Tests.Foldert
{
    [TestClass]
    public class CourseTests
    {
        private Course testCourse;
        private const int MinimalNumberOfCourses = 30;

        [TestInitialize]
        public void TestInitialize()
        {
            testCourse = new Course();
            

        }
        [TestMethod]
        public void TestListOfCourseGetter()
        {
            for (int i = 0; i < MinimalNumberOfCourses; i++)
            {
                testCourse.ListOfStudents.Add(new Student());
            }

            var gotValue = testCourse.ListOfStudents;

            Assert.AreEqual(testCourse.ListOfStudents, gotValue);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestListOfStudentsGreaterThan30()
        {
            List<Student> greaterTestOfStudents = new List<Student>();
            for (int i = 0; i < MinimalNumberOfCourses + 1; i++)
            {
                greaterTestOfStudents.Add(new Student());
            }

            testCourse.ListOfStudents = greaterTestOfStudents;
        }

        [TestMethod]
        public void StraightPathGivingListOfStudents()
        {
            List<Student> testListOfStudents = new List<Student>();
            for (int i = 0; i < MinimalNumberOfCourses; i++)
            {
                testListOfStudents.Add(new Student());
            }

            this.testCourse.ListOfStudents = testListOfStudents;
        }
    }
}
