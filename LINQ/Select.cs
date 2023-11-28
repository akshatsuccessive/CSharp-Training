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

            var result = studentList.Select(s => new { Name = "Mr. " + s.StudentName, Age = s.Age });

            foreach(var item in result)
            {
                Console.WriteLine(item.Name + ", " + item.Age);
            }
        }
    }
}
