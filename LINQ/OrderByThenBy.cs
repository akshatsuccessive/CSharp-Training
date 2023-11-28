using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class OrderByThenBy
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

            var studentOrder = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            foreach(var item in studentOrder)
            {
                Console.WriteLine("{0} : {1}, {2}", item.StudentID, item.StudentName, item.Age);
            }
        }
    }
}
