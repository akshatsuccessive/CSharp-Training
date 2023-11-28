using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Distinct
    {
        public static void Method()
        {
            List<string> strList = new List<string>() { "One", "Two", "One", "Two", "Three" };

            var distinctElement = strList.Distinct();

            foreach(string item in distinctElement)
            {
                Console.WriteLine(item);
            }
        }
    }
}
