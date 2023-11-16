using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyDictionary
    {
        private static void Print(Dictionary<int, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("\n");
        }
        public static void Method()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Akshat");
            dict.Add(2, "Hello");
            dict.Add(3, "Govind");
            Print(dict);

            dict.Remove(1);
            Print(dict);
            Console.WriteLine(dict.ContainsKey(3));
            Console.WriteLine(dict.ContainsKey(7));
            Console.WriteLine(dict.Count);
        }
    }
}
