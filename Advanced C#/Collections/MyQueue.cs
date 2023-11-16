using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyQueue
    {
        private static void Print(Queue q)
        {
            foreach (object obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine("\n");
        }
        public static void Method()
        {
            Queue q = new Queue();
            q.Enqueue("Akshat");
            q.Enqueue(2);
            q.Enqueue("Nice");
            q.Enqueue(DateTime.Now);

            Print(q);

            q.Dequeue();
            Print(q);
        }
    }
}
