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
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Name: {name} - Invalid input");
            }
            Name = name;
            SchoolId = School.GetRandomNumberInRange();
        }
       
    }
}
