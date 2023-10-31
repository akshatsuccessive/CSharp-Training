using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MagicalString
    {
        private static bool IsMagical(int num)
        {
            StringBuilder sb = new StringBuilder(str);
            int sum = 0;
            bool endProcess = false;
            while (!endProcess)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    int num = sb[i] - '0';
                    sum += num;
                }
                if (sum >= 10)
                {
                    sb.Clear();
                    sb.Append(sum.ToString());
                    sum = 0;
                }
                else
                {
                    endProcess = true;
                }
            }
            return sum == 1;
        }
        public static void IsMagicalString()
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();

            if (IsMagical(str))
            {
                Console.WriteLine("Yes, the input string is magical");
            }
            else
            {
                Console.WriteLine("Input string is not magical");
            }

            Console.ReadKey();
        }
    }
}
