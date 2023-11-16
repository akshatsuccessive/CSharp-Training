using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class DemoClass
    {
        public DemoClass()
        {
            Console.WriteLine("Demo class Constructor called");
        }

        public void DoSomething()
        {
            Console.WriteLine("Method of DemoClass called");
        }
    }

    class GenericClassNew<T> where T : new()
    {
        public T GetInstance()
        {
            return new T();
        }
    } 

    class GenericConstraintsNew
    {
        public static void Method()
        {
            GenericClassNew<DemoClass> obj = new GenericClassNew<DemoClass>();

            DemoClass classInstance = obj.GetInstance();

            classInstance.DoSomething();
        }
    }
}
