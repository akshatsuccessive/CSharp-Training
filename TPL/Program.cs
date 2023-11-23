using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //TPLFor.Method();
            //StandardFor.Method();
            //ParallelFor.Method();
            ParallelInvoke.Method();

            Console.ReadKey();
        }
    }
}
