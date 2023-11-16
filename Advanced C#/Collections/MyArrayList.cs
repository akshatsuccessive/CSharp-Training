using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyArrayList
    {
        public static void Method()
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(10);
            myArrayList.Add("Akshat");
            myArrayList.Add(90.9);
            myArrayList.Add(DateTime.Now);

            foreach(var item in myArrayList)
            {
                Console.Write(item + "\t");
            }
        }
    }
}

