using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class DemoConstants
    {
        public static void Print()
        {
            Console.WriteLine(UseConstants.ConstVal);
        }
    }
    class UseConstants
    {
        public const string ConstVal = "Never changed";
        //public void Method()
        //{
        //    ConstVal = "Changed";
        //}
        public static void Method()
        {
            //var obj = new Program();
            Console.WriteLine(ConstVal);
            DemoConstants.Print();
        }
    }
}
