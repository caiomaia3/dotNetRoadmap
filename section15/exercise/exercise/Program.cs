using System;
using System.Collections.Generic;
using exercise.Entities;
using exercise.Service;
struct Classe
{
    public string className;
    public int[] students;
}

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {   
           //Mock da entrada 
            string myMsg;

            myMsg = "How many students for course "; 
            Classe[] cl = new Classe[3];

            cl[0].className = "A";
            cl[0].students = new int[3] {21, 35, 22};

            cl[1].className = "B";
            cl[1].students = new int[2] {21,50};

            cl[2].className = "C";
            cl[2].students = new int[3] {42,35,13};


            try
            {
                List<Course> courses = new List<Course>();
                for (int i = 0; i < cl.Length; i++)
                {
                    HashSet<User> students = new HashSet<User>();
                    for (int j = 0; j < cl[i].students.Length; j++)
                    {
                        students.Add( new Student(cl[i].students[j]) );
                    }
                    courses.Add(new Course(cl[i].className,students));
                }
                System.Console.WriteLine();
                foreach (Course c in courses)
                {
                    System.Console.WriteLine(myMsg + c.CourseName + "?");
                    foreach (Student s in c.Students)
                    {
                        System.Console.WriteLine(s.Id + " - "+ s.GetHashCode());
                    }
                }


                // Counting students. 
                System.Console.Write("Total students: "); 
                System.Console.WriteLine( new CourseService(courses).CountStudents());

            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}