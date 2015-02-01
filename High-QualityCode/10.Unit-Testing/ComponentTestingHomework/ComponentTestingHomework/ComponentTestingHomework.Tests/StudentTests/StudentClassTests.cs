
namespace ComponentTestingHomework.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using ComponentTestingHomework;

    [TestClass]
    public class TestStudentClass
    {
        private Student testStudent;

        [TestInitialize]
        public void InitializeTestStudent()
        {
            testStudent = new Student();
        }
        
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestNameWithEmptyValue()
        {
            testStudent.Name = "";
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestNameWithNullValue()
        {
            testStudent.Name = null;
        }

        [TestMethod]
        public void StraightPathStudentName()
        {
            testStudent.Name = "Gosho";
        }

        [TestMethod]
        public void TestStudentNameGetter()
        {
            testStudent.Name = "George";
            string expectedName = "George";

            Assert.AreEqual(testStudent.Name, expectedName);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestNumberWithOutrangedValueOnLeft()
        {
            testStudent.Number = 10000 - 1;
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestNumberWithOutrangedValueOnRight()
        {
            testStudent.Number = 99999 + 1;
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestNumberWithNegativeValue()
        {
            testStudent.Number = -100;
        }

        [TestMethod]
        public void TestStudentNumberGetter()
        {
            testStudent.Number = 12345;
            int expectedNumber = 12345;

            Assert.AreEqual(testStudent.Number, expectedNumber);
        }

        [TestMethod]
        public void TestNumberHappyPath()
        {
            Random number = new Random();
            testStudent.Number = number.Next(10000, 99999);
        }

        [TestMethod]
        public void TestAddCourseMethod()
        {
            testStudent.ListOfCourses = new List<Course>();
            Course course = new Course();
            testStudent.AddCourse(course);
            Assert.AreNotEqual(0, testStudent.ListOfCourses.Count);
        }

        [TestMethod]
        public void TestLeaveCourse()
        {
            testStudent.ListOfCourses = new List<Course>();
            Course course = new Course();
            testStudent.AddCourse(course);
            testStudent.LeaveCourse(course);
            Assert.AreEqual(0, testStudent.ListOfCourses.Count);
        }

    }
}
