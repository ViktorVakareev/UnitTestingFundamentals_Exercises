using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolExercise;
using System;

namespace MsTests
{
    [TestClass]
    public class SchoolTests
    {

        [TestMethod]
        public void AddValidStudents()
        {

            var _school = new School();
            string name = "Luka Dukic";

            //var _student = new Student(name, Id);

            for (int i = 0; i < 10; i++)
            {
                _school.AddStudent($"{name} {i}");
            }

            Assert.AreEqual(10, _school.studentsList.Count);
        }

        [TestMethod]
        public void TryAddingExistingStudent()
        {

            var _school = new School();
            string name = "Luka Dukic";
            //string name2 = "Lukad Dukicd";

            //var _student = new Student(name, Id);

            _school.AddStudent(name);

            Assert.ThrowsException<ArgumentException>(() => _school.AddStudent(name));
        }
                
       
    }
}