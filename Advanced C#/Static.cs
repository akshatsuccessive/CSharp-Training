using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    class Demo
    {
        public static string staticVal = "Static value";
        public static string staticVal1;

        public readonly static string staticReadOnlyVal = "Readonly only value";
        public readonly static string staticReadOnlyVal1;

        public Demo()
        {
            staticVal = "Changed 1";
            staticVal1 = "Assinged in constructor";
            //staticReadOnlyVal = "Not changed";
            //staticReadOnlyVal1 = "Not changed";
        }

        static Demo()
        {
            staticReadOnlyVal = "Value can be changed here";
            staticReadOnlyVal1 = "Value can be changed here 1"; 
        }
    }
    class Program
    {
        public Program()
        {
            Demo.staticVal = "Changed here in Program Constructor";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Demo.staticVal);
            Console.WriteLine(Demo.staticVal1);
            Console.WriteLine(Demo.staticReadOnlyVal);
            Console.ReadKey();
        }
    }
}
