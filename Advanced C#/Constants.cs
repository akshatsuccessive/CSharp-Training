using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    class Constants
    {
        class Demo
        {
            public static void Print()
            {
                Console.WriteLine(Program.ConstVal);
            }
        }
        class Program
        {
            public const string ConstVal = "Never changed";
            //public void Method()
            //{
            //    ConstVal = "Changed";
            //}
            static void Main(string[] args)
            {
                //var obj = new Program();
                Console.WriteLine(ConstVal);
                Demo.Print();
                Console.ReadKey();
            }
        }
    }
}
