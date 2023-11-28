using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class UseLast
    {
        public static void Method()
        {
            List<int> intList = new List<int>() { 10, 65, 3, 88, 52, 22, 90, 11, 4, 56, 20 };
            Console.WriteLine(intList.Last());
            Console.WriteLine(intList.LastOrDefault());
            Console.WriteLine(intList.Last(x => x % 2 != 0));
            Console.WriteLine(intList.Last(x => x > 80));
            //Console.WriteLine(intList.Last(x => x == 1));
            Console.WriteLine(intList.LastOrDefault(x => x == 1));
        }
    }
}
