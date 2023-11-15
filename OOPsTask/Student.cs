using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsTask
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        private static List<Course> _courses = new List<Course>();

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        static Student()
        {
            Course newCourse = new Course();
            newCourse.Id = "101";
            newCourse.Name = "B.Tech";
            newCourse.Code = "IT";
            _courses.Add(newCourse);
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }
        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }
        public void AddCourse(List<Course> courseList)
        {
            _courses.AddRange(courseList);
        }
    }
}
