using System;

namespace SchoolExercise
{
    public class Student
    {
        public string Name { get; set; }
        public int SchoolId { get; set; }

        public Student()
        {
        }

        public Student(string name, int schoolId)
        {
            if (String.IsNullOrEmpty(name)|| schoolId < 10000 || schoolId > 99999)
            {
                throw new ArgumentException("Invalid input");
            }
            Name = name;
            SchoolId = schoolId;
        }
        
    }
}
