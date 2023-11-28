using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class UseFirst
    {
        public static void Method()
        {
            List<int> intList = new List<int>() { 10, 65, 3, 88, 52, 22, 90, 11, 4, 56, 20 };
            Console.WriteLine(intList.First());
            Console.WriteLine(intList.FirstOrDefault());
            Console.WriteLine(intList.First(x => x % 2 != 0));
            Console.WriteLine(intList.First(x => x > 80));
            //Console.WriteLine(intList.First(x => x == 1));
            Console.WriteLine(intList.FirstOrDefault(x => x == 1));

            Console.WriteLine("\n");

            List<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            Console.WriteLine("First element of string list : {0}", strList.First());
            Console.WriteLine("First element of string list : {0}", strList.FirstOrDefault());
            //Console.WriteLine(strList.First(s => s.Length > 5));
            Console.WriteLine(strList.FirstOrDefault(s => s.Length > 5));
            Console.WriteLine(strList.First(s => s.Length > 3));
            Console.WriteLine(strList.FirstOrDefault(s => s.Length > 3));
        }
    }
}
