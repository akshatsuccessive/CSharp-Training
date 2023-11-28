using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class SkipTake
    {
        public static void Method()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var newList = list.Skip(2);
            foreach (int i in newList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            newList = list.Take(4);
            foreach (int i in newList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            List<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six" };
            var newStrList = strList.SkipWhile(s => s.Length < 4);
            foreach(var str in newStrList)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            newStrList = strList.TakeWhile(s => s.Length < 5);
            foreach(var str in newStrList)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
