using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    class SynchronousProgram
    {
        private static void StartSchoolAssembly()
        {
            Thread.Sleep(8000);
            Console.WriteLine("School Started, \t Thread : {0}", Thread.CurrentThread.ManagedThreadId);
        }

        private static void TeachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12, \t Thread : {0}", Thread.CurrentThread.ManagedThreadId);
        }
        private static void TeachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11, \t Thread : {0}", Thread.CurrentThread.ManagedThreadId);
        }

        public static void Method()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            StartSchoolAssembly();
            TeachClass12();
            TeachClass11();
            watch.Stop();
            Console.WriteLine("\nTotal Execution time : {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
