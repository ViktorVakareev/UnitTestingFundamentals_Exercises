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

      
    }
}
