using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class DemoReadOnly
    {
        public readonly string val = "Only changed in Constructor";
        public readonly string val1;
        public readonly string val2 = "Value 2";

        public DemoReadOnly()
        {
            val = "Changed";
            val1 = "Changed in constructor";
        }

        //public void Method()
        //{
        //    val = "Changed in Method";
        //}

    }
    class UseReadOnly
    {
        public static void Method()
        {
            DemoReadOnly obj = new DemoReadOnly();
            Console.WriteLine(obj.val);
            Console.WriteLine(obj.val1);
            Console.WriteLine(obj.val2);

            //Console.WriteLine(Demo.val);
        }
    }
}
