using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Select
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "John" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Steve" , Age = 15 }
            };

            var resultAge = studentList.Select(s => new { Age = s.Age, Salary = 25000 });
            foreach (var item in resultAge)
            {
                Console.WriteLine("Age : {0} and Salary : {1}", item.Age, item.Salary);
            }

            Console.WriteLine("\n");

            var teenAgers = studentList.Where(s => s.Age >= 13 && s.Age <= 19).Select(s => s.Age);
            foreach (int item in teenAgers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
