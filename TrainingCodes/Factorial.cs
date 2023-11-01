using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        private static int CalculateFactorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            return num * CalculateFactorial(num - 1);
        }

        private static void Solve()
        {
            int num;
            Console.Write("\nEnter a number : ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out num))
            {
                if (num < 0)
                {
                    Console.WriteLine("\nInvalid input, Please enter a Postive integer\n");
                }
                else
                {
                    int ans = CalculateFactorial(num);
                    Console.WriteLine("\nThe Factorial of {0} is : {1}\n\n", num, ans);
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input, Please enter a valid postive Integer\n");
            }
        }

        static void Main(string[] args)
        {
            bool endProcess = false;
            do
            {
                Console.WriteLine("Enter a option :-");
                Console.WriteLine("1. Find Factorial");
                Console.WriteLine("2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Solve();
                        break;

                    case 2:
                        endProcess = true;
                        Console.WriteLine("\nExit.....");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option, Please try again\n");
                        break;
                }
            } while (!endProcess);
            Console.ReadKey();
        }
    }
}
