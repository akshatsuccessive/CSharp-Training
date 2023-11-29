using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student s1, Student s2)
        {
            return s1.StudentID == s2.StudentID && s1.StudentName.ToLower() == s2.StudentName.ToLower();
        }
        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
    class Distinct
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var distinctStudnets = studentList.Distinct(new StudentComparer());
            foreach (var item in distinctStudnets)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }
        }
    }
}
