using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_AsyncAwait
{
    class ParallelInvoke
    {
        private static void Method1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Method 1 Completed by Thread : {0}", Thread.CurrentThread.ManagedThreadId);
        }
        private static void Method2()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Method 2 Completed by Thread : {0}", Thread.CurrentThread.ManagedThreadId);
        }
        private static void Method3()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Method 3 Completed by Thread : {0}", Thread.CurrentThread.ManagedThreadId);
        }

        public static void Method()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //Method1();
            //Method2();
            //Method3();

            Parallel.Invoke(
                Method1, Method2, Method3
            );

            stopWatch.Stop();
            Console.WriteLine("Parallel execution takes : {0} millisecond", stopWatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
