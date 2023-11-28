using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Aggregate
    {
        public static void Method()
        {
            List<int> list = new List<int>() { 32, 54, 10, 5, 1, 76 };

            Console.WriteLine("Sum is : {0}", list.Sum());
            Console.WriteLine("Count of elements in list : {0}", list.Count());
            Console.WriteLine("Average of elements in list : {0}", list.Average());

            Console.WriteLine("Maximum element in list : {0}", list.Max());
            Console.WriteLine("Minimum element in list : {0}", list.Min());
        }
    }
}
