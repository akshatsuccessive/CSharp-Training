using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Deffered
    {
        private static void PrintStudents(List<Student> studentList)
        {
            foreach (var item in studentList)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }
        }
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 12 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 22 }
            };

            var tempStudents = studentList;

            PrintStudents(tempStudents);

            studentList.Add(new Student() { StudentID = 6, StudentName = "Akshat", Age = 21 });

            Console.WriteLine("\n-----------------------------\n");

            PrintStudents(tempStudents);
        }
    }
}
