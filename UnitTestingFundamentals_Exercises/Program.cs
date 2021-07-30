using SchoolExercise;
using System;

namespace SchoolExercise

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var school1 = new School();
            
            school1.AddStudent("Johnie Walker");
            school1.AddStudent("Kerry Walker");
            school1.AddStudent("Kerry Washington");
            //school1.AddStudent("Kerry Washington");   // Add student with existing in the List<Student> name

            var nature = new Course();
            nature.JoinCource(school1.studentsList[0]);

            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
            //Console.WriteLine(student3);

            Console.WriteLine(school1.ToString());
        }


    }
}
