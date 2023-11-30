using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class ToLookUp
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
            };

            var groupedResult = studentList.ToLookup(s => s.Age);
            studentList.Add(new Student() { StudentID = 6, StudentName = "Akshat", Age = 21 });

            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age : {0}", ageGroup.Key);

                foreach (var student in ageGroup)
                {
                    Console.WriteLine("           Student name : {0}", student.StudentName);
                }
            }


            Console.WriteLine("\n----------------------\n");
            studentList.Add(new Student() { StudentID = 7, StudentName = "Bohra", Age = 23 });

            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age : {0}", ageGroup.Key);

                foreach (var student in ageGroup)
                {
                    Console.WriteLine("           Student name : {0}", student.StudentName);
                }
            }

        }
    }
}
