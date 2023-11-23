using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_AsyncAwait
{
    class StandardFor
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
            for(int i = 1; i <= 10; i++)
            {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            }
            stopWatch.Stop();
            Console.WriteLine("For Loop Execution Ends\n");
            Console.WriteLine("Time taken for exectute for loop in milliseconds : {0}", stopWatch.ElapsedMilliseconds);
        }
    }
}
