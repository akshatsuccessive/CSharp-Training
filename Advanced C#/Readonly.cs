using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    class Demo
    {
        public readonly string val = "Only changed in Constructor";
        public readonly string val1;
        public readonly string val2 = "Value 2";

        public Demo()
        {
            val = "Changed";
            val1 = "Changed in constructor";
        }

        //public void Method()
        //{
        //    val = "Changed in Method";
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Console.WriteLine(obj.val);
            Console.WriteLine(obj.val1);
            Console.WriteLine(obj.val2);

            //Console.WriteLine(Demo.val);
            Console.ReadKey();
        }
    }
}
