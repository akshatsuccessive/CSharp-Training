using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class DemoStatic
    {
        public static string staticVal = "Static value";
        public static string staticVal1;

        public readonly static string staticReadOnlyVal = "Readonly only value";
        public readonly static string staticReadOnlyVal1;

        public DemoStatic()
        {
            staticVal = "Changed 1";
            staticVal1 = "Assinged in constructor";
            //staticReadOnlyVal = "Not changed";
            //staticReadOnlyVal1 = "Not changed";
        }

        static DemoStatic()
        {
            staticReadOnlyVal = "Value can be changed here";
            staticReadOnlyVal1 = "Value can be changed here 1";
        }
    }
    class UseStatic
    {
        public UseStatic()
        {
            DemoStatic.staticVal = "Changed here in Program Constructor";
        }

        public static void Method()
        {
            Console.WriteLine(DemoStatic.staticVal);
            Console.WriteLine(DemoStatic.staticVal1);
            Console.WriteLine(DemoStatic.staticReadOnlyVal);
        }
    }
}
