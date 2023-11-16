using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyHashTable
    {
        public static void Method()
        {
            Hashtable emp = new Hashtable();
            emp.Add(1, "Akshat");
            emp.Add(2, "Govind");
            emp.Add(3, "Yash");
            emp.Add("89", "Hello");
            emp.Add(DateTime.UtcNow, DateTime.Now);

            foreach(DictionaryEntry item in emp)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
