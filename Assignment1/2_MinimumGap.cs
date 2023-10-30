using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MinimumGap
    {
        private static int Solve(int num)
        {
            int squareRoot = Convert.ToInt32(Math.Sqrt(num));
            int low = squareRoot * squareRoot;
            int high = (squareRoot + 1) * (squareRoot + 1);

            return Math.Min(Math.Abs(high - num), Math.Abs(low - num));
        }
        public static void FindMinimumGap()
        {
            int num;
            Console.Write("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            int ans = Solve(num);

            Console.WriteLine(String.Format("The minimum gap to make {0} a perfect square is {1}", num, ans));

            Console.ReadKey();
        }
    }
}
