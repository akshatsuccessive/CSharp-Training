using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class OddNumberException1 : Exception
    {
        public OddNumberException1(string message) : base(message)
        { }
    }
    class CustomException3
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

                if (num2 % 2 == 1)
                {
                    throw new OddNumberException1("Divisor can not be odd");
                }
                res = num1 / num2;
                Console.WriteLine("Result is : {0}", res);
            }
            catch (OddNumberException1 one)
            {
                Console.WriteLine("Message : {0}", one.Message);
            }

            Console.WriteLine("\nLast line");
        }
    }
}
