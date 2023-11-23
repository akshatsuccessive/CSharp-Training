using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    class AsynchronousProgram
    {
        private static async Task StartSchoolAssembly()
        {
            await Task.Run(() => {
                Thread.Sleep(10000);
                Console.WriteLine("School Started, \t Thread : {0}", Thread.CurrentThread.ManagedThreadId);
            });
        }

        private static async Task TeachClass12()
        {
            await Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class 12, \t Thread : {0}", Thread.CurrentThread.ManagedThreadId);
            });
        }
        private static async Task TeachClass11()
        {
            await Task.Run(() => {
                Thread.Sleep(5000);
                Console.WriteLine("Taught class 11, \t Thread : {0}", Thread.CurrentThread.ManagedThreadId);
            });
        }

        public static async Task Method()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Task task1 = StartSchoolAssembly();
            await task1;
            Task task2 = TeachClass11();
            await task2;
            Task task3 = TeachClass12();

            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine("\nTotal Execution time : {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
