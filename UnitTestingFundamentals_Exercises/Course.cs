using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class Course
    {
        public List<Student> studentsList = new List<Student>();

        public void JoinCource(Student student)
        {
            if (studentsList.Count >= 30) 
            {
                throw new ArgumentException("The course quote is full. No more students can join");            
            }
            studentsList.Add(student);
        }
        public void LeaveCource(string name)
        {
            foreach (var pupil in studentsList)
            {
                if (pupil.Name.Equals(name))
                {
                    throw new ArgumentException($"Student with name {name} doesn't exist!");
                }
            }           

            studentsList.Remove(studentsList.First(x => x.Name.Equals(name)));
        }

    }    

}
