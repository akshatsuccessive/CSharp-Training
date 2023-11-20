using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class OddNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "Divisor can not be odd";
            }
        }
    }
    class CustomException2
    {
        public static void Method()
        {
            int num1, num2, res;
            try
            {
                Console.Write("Enter first number : ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number : ");
                num2 = int.Parse(Console.ReadLine());

                if(num2 % 2 == 1)
                {
                    throw new OddNumberException();
                }
                res = num1 / num2;
                Console.WriteLine("Result is : {0}", res);
            }
            catch (OddNumberException one)
            {
                Console.WriteLine("Message : {0}", one.Message);
            }

            Console.WriteLine("\nLast line");
        }
    }
}
