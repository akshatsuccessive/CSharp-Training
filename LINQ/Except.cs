using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Except
    {
        public static void Method()
        {
            List<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            List<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 3, StudentName = "BILL",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Max", Age = 20}
            };

            var difference = studentList1.Except(studentList2, new StudentComparer());
            foreach (var item in difference)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }
        }
    }
}
