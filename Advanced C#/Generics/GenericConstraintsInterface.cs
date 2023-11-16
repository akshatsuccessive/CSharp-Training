using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    interface MyInterface
    {
        void SomeMethod();
    }

    class MyClass : MyInterface
    {
        public void SomeMethod()
        {
            Console.WriteLine("Interface method called");
        }
    }

    class GenericClass<T> where T : MyInterface
    {
        public void GenericMethod(T param)
        {
            param.SomeMethod();
        }
    }

    class GenericConstraintsInterface
    {
        public static void Method()
        {
            GenericClass<MyClass> obj = new GenericClass<MyClass>();

            obj.GenericMethod(new MyClass());
        }
    }
}
