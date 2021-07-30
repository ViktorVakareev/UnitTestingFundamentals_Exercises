using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Assert.AreEqual(listOfStudentsInitialCount, course.studentsList.Count - 1 );
        }

    }
}
