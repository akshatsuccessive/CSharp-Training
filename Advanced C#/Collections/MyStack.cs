using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyStack
    {
        private static void Print(Stack st)
        {
            foreach (var item in st)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
        public static void Method()
        {
            Stack st = new Stack();
            st.Push("Akshat");
            st.Push(2);
            st.Push("Nice");
            st.Push(DateTime.Now);

            Print(st);

            st.Pop();
            Print(st);
        }
    }
}
