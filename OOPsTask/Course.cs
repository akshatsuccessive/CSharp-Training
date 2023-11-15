using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsTask
{
    class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        private static List<CourseSubject> _subjects = new List<CourseSubject>();
        static Course()
        {
            CourseSubject newSubject = new CourseSubject();
            newSubject.Id = "101";
            newSubject.Name = "English";
            newSubject.Code = "Eng";
            _subjects.Add(newSubject);
        }

        public static List<CourseSubject> Subjects
        {
            get
            {
                return _subjects;
            }
        }
        public void AddSubjects(CourseSubject subject)
        {
            _subjects.Add(subject);
        }
        public void AddSubjects(List<CourseSubject> subjects)
        {
            _subjects.AddRange(subjects);
        }

        public void RemoveSubjects(CourseSubject subject)
        {
            _subjects.Remove(subject);
        }
    }
}
