using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_AsyncAwait
{
    class ParallelFor
    {
        private static long DoSomeIndependentTask()
        {
            // time consuming task
            long sum = 0;
            for (int i = 1; i <= 100000000; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static void Method()
        {
            DateTime StartDateTime = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("For Loop Execution starts\n");
            stopWatch.Start();
            Parallel.For(1, 10, count => {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}, \t thread : {2}", count, total, Thread.CurrentThread.ManagedThreadId);
            });

            stopWatch.Stop();
            Console.WriteLine("For Loop Execution Ends\n");
            Console.WriteLine("Time taken for exectute for loop in milliseconds : {0}", stopWatch.ElapsedMilliseconds);
        }
    }
}
