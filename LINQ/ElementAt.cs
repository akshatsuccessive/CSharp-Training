using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class ElementAt
    {
        public static void Method()
        {
            List<int> intList = new List<int>() { 32, 44, 10, 19, 25, 94 };
            List<string> strList = new List<string>() { "One", "Two", "Three", null, "Four", "Five" };

            Console.WriteLine("First element in interger list : {0}", intList.ElementAt(0));
            Console.WriteLine("First element in interger list : {0}", intList.ElementAtOrDefault(0));
            Console.WriteLine("First element in string list : {0}", strList.ElementAt(0));
            Console.WriteLine("First element in string list : {0}", strList.ElementAtOrDefault(0));
            Console.WriteLine();

            Console.WriteLine("Fourth element in string list : {0}\n", strList.ElementAt(3));

            //Console.WriteLine(intList.ElementAt(9));
            Console.WriteLine("9th element in integer list : {0}", intList.ElementAtOrDefault(9));
            //Console.WriteLine(strList.ElementAt(9));
            Console.WriteLine("9th element in string list : {0}", strList.ElementAtOrDefault(9));
        }
    }
}
