using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProcess = false;
            do
            {
                Console.WriteLine("\nEnter a option :-");
                Console.WriteLine("1. Find Balanced Index");
                Console.WriteLine("2. Find Leaders in a Array");
                Console.WriteLine("3. Lazy Person");
                Console.WriteLine("4. Find out Maximum sum subarray");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        BalancedIndex.FindBalancedIndex();
                        break;

                    case "2":
                        Leaders.CountLeaders();
                        break;

                    case "3":
                        MinimumSwitches.CountMinimumSwitches();
                        break;

                    case "4":
                        MaximumSubarraySum.FindSum();
                        break;

                    case "5":
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
