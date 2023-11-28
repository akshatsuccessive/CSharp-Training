using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class UseSingle
    {
        public static void Method()
        {
            List<int> list = new List<int>() { 13, 5, 5, 64, 12, 98, 54, 22 };
            //Console.WriteLine(list.Single());
            Console.WriteLine(list.Single(x => x == 64));
            //Console.WriteLine(list.Single(x => x == 5));
            //Console.WriteLine(list.Single(x => x == 10));

            //Console.WriteLine(list.SingleOrDefault(x => x == 5));
            Console.WriteLine(list.SingleOrDefault(x => x == 98));
            Console.WriteLine(list.SingleOrDefault(x => x == 22));
            Console.WriteLine(list.SingleOrDefault(x => x == 10));

            Console.WriteLine("\n");

            List<string> strList = new List<string>() { null, "One", "Two", "Three", "One" };
            Console.WriteLine(strList.Single(s => s == "Two"));
            //Console.WriteLine(strList.SingleOrDefault(s => s == "One"));
        }
    }
}
