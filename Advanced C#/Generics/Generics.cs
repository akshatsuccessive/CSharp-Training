using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class Comparer
    {
        // Generic method
        public bool IsEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
    class TestGenericClass<T>
    {
        private T var1;
        public T var2 { get; set; }

        public TestGenericClass(T value)
        {
            var1 = value;
            var2 = value;
        }

        public T TestMethod(T param1)
        {
            Console.WriteLine("Parameter type: {0}, value {1}", typeof(T).ToString(), param1);
            Console.WriteLine("Return type: {0}, value {1}", typeof(T).ToString(), var1);
            return var1;
        }
    }


    class Generics
    {
        public static void Method()
        {
            /*
            Comparer comparer = new Comparer();
            Console.WriteLine(comparer.IsEqual<int>(8, 9));
            Console.WriteLine(comparer.IsEqual<string>("xyz", "xyz"));
            */

            TestGenericClass<int> obj = new TestGenericClass<int>(870);
            Console.WriteLine(obj.TestMethod(45));

            Console.WriteLine("\n");

            TestGenericClass<string> obj2 = new TestGenericClass<string>("Hello");
            Console.WriteLine(obj2.TestMethod("Akshat"));

            Console.ReadKey();
        }
    }
}
