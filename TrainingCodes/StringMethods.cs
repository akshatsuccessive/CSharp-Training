using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Akshat";
            string str2 = "Kumar";
            int age = 21;
            // str = "Akshat Kumar";

            Console.WriteLine(str1.Length);
            Console.WriteLine(String.Format("My age is : {0}", age));
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            // concatenation
            string newString = String.Concat(str1, str2);
            Console.WriteLine(newString);

            // contains
            Console.WriteLine(str1.Contains(str2));

            // replace
            Console.WriteLine(str1.Replace('A', 'Z'));

            string str3 = "Hello";
            string str4 = "Hello";

            // compare
            Console.WriteLine(String.Compare(str3, str4));


            // substring
            string substr = str1.Substring(0, 3);
            Console.WriteLine(substr);

            // trim
            string inputStr = "   Hello World!  ";
            Console.WriteLine(inputStr.Trim());

            // remove
            Console.WriteLine(str1.Remove(0, 3));

            // string builder
            var sb = new StringBuilder("Hello");
            Console.WriteLine(sb);
            sb.Append(" My name is Akshat");
            Console.WriteLine(sb);

            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.AppendFormat(" My age is : {0}", age));
            Console.ReadKey();
        }
    }
}
