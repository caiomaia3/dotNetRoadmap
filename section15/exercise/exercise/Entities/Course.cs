using System.Collections.Generic;
namespace exercise.Entities
{
    public class Course
    {
        public string CourseName { get; private set; }
        public HashSet<User> Students {get; private set;}
        public Course(string name)
        {
            CourseName = name;
        }
        public Course(string name, HashSet<User> students) : this(name)
        {
            Students = students;
        }
    }

}