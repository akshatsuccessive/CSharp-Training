using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //OrderByThenBy.Method();
            //Select.Method();
            //Distinct.Method();
            //SkipTake.Method();
            //Where.Method();
            //UseFirst.Method();
            UseSingle.Method();

            Console.ReadKey();
        }
    }
}
