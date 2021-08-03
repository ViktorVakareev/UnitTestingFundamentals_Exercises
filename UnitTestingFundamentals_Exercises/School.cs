using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolExercise

{
    public class School
    {
        public List<Student> studentsList;
        private int currentId;

        public School(int Id)
        {
            if (Id < 10000 || Id > 99999)
            {
                throw new ArgumentException($"Invalid ID!");
            }
            studentsList = new List<Student>();
            currentId = Id;
        }
        public School()
        {
            
            studentsList = new List<Student>();
            currentId = School.GetRandomNumberInRange();
        }

        public void AddStudent(string name)
        {
            foreach (var pupil in studentsList)
            {
                if (pupil.Name.Equals(name))
                {
                    throw new ArgumentException($"Student with name {name} already exists!");
                }
                if (pupil.SchoolId < 10000 || pupil.SchoolId > 99999)
                {
                    throw new ArgumentException($"Invalid ID!");
                }
            }

            var student = new Student(name, currentId);
            studentsList.Add(student);
        }
        public void AddStudent(string name, int Id)
        {
            foreach (var pupil in studentsList)
            {
                if (pupil.Name.Equals(name))
                {
                    throw new ArgumentException($"Student with name {name} already exists!");
                }
                
            }

            var student = new Student(name, currentId);
            studentsList.Add(student);
        }
        public static int GetRandomNumberInRange()
        {
            var rand = new Random();
            return rand.Next(10000, 99999);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var pupil in studentsList)
            {
                sb.Append($"{pupil.Name} {pupil.SchoolId}\n");
            }
            return sb.ToString();
        }
    }
}
