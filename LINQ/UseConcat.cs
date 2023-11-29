using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class UseConcat
    {
        public static void Method()
        {
            List<string> list1 = new List<string>() { "One", "Two", "Three", "Four" };
            List<string> list2 = new List<string>() { "One", "Two", "Five", "Six" };

            var resultList = list1.Concat(list2);
            foreach(var item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
