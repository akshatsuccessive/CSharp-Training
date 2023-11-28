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
                Console.WriteLine("9. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("\n");
                        Distinct.Method();
                        break;

                    case "2":
                        Console.WriteLine("\n");
                        Select.Method();
                        break;

                    case "3":
                        Console.WriteLine("\n");
                        Where.Method();
                        break;

                    case "4":
                        Console.WriteLine("\n");
                        SkipTake.Method();
                        break;

                    case "5":
                        Console.WriteLine("\n");
                        UseFirst.Method();
                        break;

                    case "6":
                        Console.WriteLine("\n");
                        UseLast.Method();
                        break;

                    case "7":
                        Console.WriteLine("\n");
                        UseSingle.Method();
                        break;

                    case "8":
                        Console.WriteLine("\n");
                        OrderByThenBy.Method();
                        break;

                    case "9":
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
