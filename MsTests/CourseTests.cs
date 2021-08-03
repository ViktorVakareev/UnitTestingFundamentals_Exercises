using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolExercise;
using System;

namespace MsTests
{
    [TestClass]
   public class CourseTests
    {
        
        [TestMethod]
        public void StudentJoinsCourseSuccessfully()
        {
            Course course = new Course();
            var student = new Student($"Joko Rosic", School.GetRandomNumberInRange());
            course.JoinCource(student);
            int listOfStudentsInitialCount = course.studentsList.Count;
            Assert.AreEqual(listOfStudentsInitialCount, course.studentsList.Count);
        }

        [TestMethod]
        public void StudentLeavesCourseSuccessfully()
        {
            Course course = new Course();
            var student = new Student($"Joko Rosic", School.GetRandomNumberInRange());
            var student2 = new Student($"Koko Musa", School.GetRandomNumberInRange());
            course.JoinCource(student);
            course.JoinCource(student2);
            int listOfStudentsInitialCount = course.studentsList.Count;
            course.LeaveCource("Koko Musa");
            Assert.AreEqual(listOfStudentsInitialCount, course.studentsList.Count + 1 );
        }
        [TestMethod]
        public void StudentNotAllowedToJoinWhenCourseIsFull()
        {
            Course course = new Course();
            for (int i = 0; i < 30; i++)
            {                
                course.JoinCource(new Student($"Joko Rosic {i}", School.GetRandomNumberInRange()));
            }

            Assert.ThrowsException<ArgumentException>(() => course.JoinCource(new Student($"Muka Jukic", School.GetRandomNumberInRange())));
        }
       

    }
}
