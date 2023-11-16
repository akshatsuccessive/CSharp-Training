using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GenericQueue
    {
        private static void Print(Queue<int> q)
        {
            foreach(var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Method()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(81);
            q.Enqueue(45);
            q.Enqueue(13);
            q.Enqueue(78);
            q.Enqueue(90);
            Print(q);

            q.Dequeue();

            Print(q);

            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Count);
        }
    }
}
