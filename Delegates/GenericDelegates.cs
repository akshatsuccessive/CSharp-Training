using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
    class GenericDelegates
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            return str.Length > 5;
        }

        public static void Method()
        {
            Func<int, float, double, double> del1 = new Func<int, float, double, double>(AddNums1);
            double res = del1(12, 54.55f, 1764.883);
            Console.WriteLine(res);

            Action<int, float, double> del2 = new Action<int, float, double>(AddNums2);
            del2(12, 54.55f, 1764.883);

            Predicate<string> del3 = new Predicate<string>(CheckLength);    // or Func<string, bool>
            Console.WriteLine(del3("Akshat"));

            Console.ReadKey();
        }
    }
}
