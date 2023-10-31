using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class RemoveSpaces
    {
        private static string PrintString(string str)
        {
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    continue;
                }
                else
                {
                    ans += str[i];
                }
            }
            Console.WriteLine(ans);
        }
        public static void RemoveMultipleSpaces()
        {
            string str;
            Console.Write("Enter a string : ");
            str = Console.ReadLine();

            str = str.Trim();

            Console.Write("\n");

            PrintStringWithoutMultipleSpaces(str);

            Console.ReadKey();
        }
    }
}
