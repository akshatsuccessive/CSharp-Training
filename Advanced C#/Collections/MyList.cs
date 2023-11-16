using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyList
    {
        public static void Method()
        {
            List<int> myList = new List<int>();
            myList.Add(34);
            myList.Add(90);
            myList.Add(32);
            myList.Add(89);
            myList.Add(14);
            foreach(var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            Console.WriteLine(myList.Count);
        }
    }
}
