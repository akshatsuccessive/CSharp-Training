using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endProcess = false;
            do
            {
                Console.WriteLine("\nENTER YOUR CHOICE - ");
                Console.WriteLine("1. Distinct");
                Console.WriteLine("2. Select");
                Console.WriteLine("3. Where");
                Console.WriteLine("4. Skip/Skipwhile and Take/Takewhile");
                Console.WriteLine("5. First / FirstOrDefault");
                Console.WriteLine("6. Last / LastOrDefault");
                Console.WriteLine("7. Single / SingleOrDefault");
                Console.WriteLine("8. OrderBy and ThenBy");
                Console.WriteLine("9. Max, Min, Count, Average and Sum");
                Console.WriteLine("10. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Distinct.Method();
                        break;

                    case "2":
                        Select.Method();
                        break;

                    case "3":
                        Where.Method();
                        break;

                    case "4":
                        SkipTake.Method();
                        break;

                    case "5":
                        UseFirst.Method();
                        break;

                    case "6":
                        UseLast.Method();
                        break;

                    case "7":
                        UseSingle.Method();
                        break;

                    case "8":
                        OrderByThenBy.Method();
                        break;

                    case "9":
                        Aggregate.Method();
                        break;

                    case "10":
                        endProcess = true;
                        Console.WriteLine("\n\nEXIT.......");
                        break;

                    default:
                        Console.WriteLine("Invalid option, Please try again........\n");
                        break;
                }
            }
            while (!endProcess);

            Console.ReadKey();
        }
    }
}
