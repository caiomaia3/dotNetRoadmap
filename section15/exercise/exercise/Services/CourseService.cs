using System.Collections.Generic;
using exercise.Entities;

namespace exercise.Service
{

    public class CourseService
    {
        public List<Course> CourseList;

        public CourseService()
        {
            CourseList = new List<Course>();
        }
        public CourseService(List<Course> courses)
        {
            CourseList = courses;
        }

        public int CountStudents()
        {
            if(CourseList == null)
            {
                throw new System.FieldAccessException("There is no Courses in the Course List to be Accessed!");
            }
            else
            {
                HashSet<User> resultantSet = new HashSet<User>();
                foreach (Course course in CourseList)
                {
                    resultantSet.UnionWith(course.Students);
                }
                return resultantSet.Count;
            }
        }

        
        
    }
}

