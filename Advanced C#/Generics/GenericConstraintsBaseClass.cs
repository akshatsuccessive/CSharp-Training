using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class BaseClass
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base class Method called");
        }
    }
    class DerivedClass : BaseClass
    {
        public void DerivedMethod()
        {
            Console.WriteLine("Derived class Method called");
        }
    }
    class GenericClassBase<T> where T : BaseClass
    {
        public void DoSomething(T instance)
        {
            instance.BaseMethod();
        }
    }
    class GenericConstraintsBaseClass
    {
        public static void Method()
        {
            GenericClassBase<BaseClass> obj = new GenericClassBase<BaseClass>();
            obj.DoSomething(new BaseClass());
        }
    }
}
