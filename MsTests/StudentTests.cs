using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolExercise;
using System;

namespace MsTests
{
    [TestClass]
    public class StudentTests
    {
        // Valid data tests
        [TestMethod]
        public void CreateValidStudent()
        {
            string name = "Nusa Doro";
            int Id = School.GetRandomNumberInRange();

            var student = new Student(name, Id);

            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(Id, student.SchoolId);
        }

        //Invalid data tests
        [TestMethod]
        public void TryCreatingWithNullName()
        {
            string name = null;
            int Id = School.GetRandomNumberInRange();

            Assert.ThrowsException<ArgumentException>(() => (new Student(name, Id)));

        }

        [TestMethod]
        public void TryCreatingWithEmptyName()
        {
            string name = "";
            int Id = School.GetRandomNumberInRange();

            Assert.ThrowsException<ArgumentException>(() => (new Student(name, Id)));

        }
        [TestMethod]
        public void TryAddingStudentIdUnderRange()
        {
            int Id = 9999;
            
            Assert.ThrowsException<ArgumentException>(() => new Student("Assen", Id));
        }
        [TestMethod]
        public void TryAddingValidStudentIdOnBoundaryLow()
        {
            int Id = 10_000;
            var student = new Student("Assen", Id);
            Assert.IsNotNull(student);
        }

        [TestMethod]
        public void TryAddingStudentIdAboveRange()
        {
            int Id = 100_000;
            
            Assert.ThrowsException<ArgumentException>(() => new Student("Assen", Id));
        }


        [TestMethod]
        public void TryAddingStudentIdOnBoundaryHigh()
        {
            int Id = 99_999;
            var student = new Student("Assen", Id);
            Assert.IsNotNull(student);
        }

    }
}

