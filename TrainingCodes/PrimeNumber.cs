using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static int CountFactors(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            int count = 2;
            for(int i = 2; i * i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                    if(i * i != num)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static bool isPrime(int num)
        {
            return CountFactors(num) == 2;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int factors = CountFactors(num);
            Console.WriteLine(String.Format("The number of factors of {0} is {1}\n", num, factors));

            if(isPrime(num))
            {
                Console.WriteLine(String.Format("The number {0} is prime", num));
            }
            else
            {
                Console.WriteLine(String.Format("The number {0} is not prime", num));
            }


            // largest prime number 
            if(isPrime(num))
            {
                Console.WriteLine(String.Format("The largest prime number is {0}", num));
            }
            else
            {
                for(int i = num - 1; i >= 2; i--)
                {
                    if(isPrime(i))
                    {
                        Console.WriteLine(String.Format("The largest prime number {0}", i));
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
