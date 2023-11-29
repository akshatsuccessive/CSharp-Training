using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Where.Method();
            //SkipTake.Method();
            //UseFirst.Method();
            //UseLast.Method();
            //UseSingle.Method();
            //OrderByThenBy.Method();
            //Aggregate.Method();
            //Joins.Method();
            //AnyAll.Method();
            //UseConcat.Method();
            //Distinct.Method();
            //Select.Method();
            //Except.Method();
            //Intersect.Method();
            Union.Method();

            Console.ReadKey();
        }
    }
}
