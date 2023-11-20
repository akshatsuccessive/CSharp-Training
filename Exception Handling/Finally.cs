using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Finally
    {
        private static void SomeMethod()
        {
            try
            {
                Console.WriteLine("Inside SomeMethod");
                int a = 10, b = 0;
                int c = a / b; 
                Console.WriteLine("Result : {0}", c);
            }
            finally
            {
                Console.WriteLine("SomeMethod finally Block");
            }
        }
        public static void Method()
        {
            try
            {
                SomeMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught : {0}", ex.Message);
            }
        }
    }
}
