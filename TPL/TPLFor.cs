using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_AsyncAwait
{
    class TPLFor
    {
        public static void Method()
        {
            /*
            Parallel.For(1, 11, num => {
                Console.Write(num + " ");
            });
            */
       
            Console.WriteLine("Standard For Loop");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Iteration count : {0}, \t thread : {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Parallel For Loop");
            Parallel.For(1, 11, count => {
                Console.WriteLine("Iteration count : {0}, \t thread : {1}", count, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            });
        }
    }
}
