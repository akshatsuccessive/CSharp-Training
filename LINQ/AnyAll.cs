using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class AnyAll
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            bool areAllStudentTeenAger = studentList.All(s => s.Age >= 13 && s.Age <= 19);
            Console.WriteLine(areAllStudentTeenAger);

            bool isAnyStudentTeenAger = studentList.Any(s => s.Age >= 13 && s.Age <= 19);
            Console.WriteLine(isAnyStudentTeenAger);

        }
    }
}
