using System;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit type casting (smaller type size to larger type size)
            int myNum = 49;
            float myFloat = myNum;             // int to float
            double mydouble = myNum;           // int to double
            long myLong = myNum;               // int to long

            // character to integer (implicit type casting)
            char ch = 'B';
            int a = ch;


            // Explicit type casting

            // double to int
            double myDouble = 5432.2521;
            int doubleToInt = (int)myDouble;

            // double to int using method
            int doubleToInt2 = Convert.ToInt32(myDouble);


            // float to int
            float salary = 25000.0041f;
            int salaryInt = Convert.ToInt32(salary);


            //double to string
            double myNum2 = 140.885;
            string str = myNum2.ToString();

            // string to integer 
            string myStr = "187";
            int strToInt = Convert.ToInt32(myStr);

            // string to integer with parse
            string myStr2 = "1031";
            int strToInt2 = int.Parse(myStr2);

            // string to integer with tryparse
            string myStr3 = "90314";
            int strToInt3;
            if (int.TryParse(myStr3, out strToInt3))
            {
                Console.WriteLine(strToInt3);
            }
            else
            {
                Console.WriteLine("Invalid integer");
            }

            // integer to string
            int num = 2788;
            string intToStr = Convert.ToString(num);



            // bool to string
            bool myBool = true;
            string boolToStr = Convert.ToString(myBool);



            // bool to integer 
            bool myBool2 = false;
            int boolToInt = Convert.ToInt32(myBool2);


            // integer to boolean
            int n = 1;
            bool isTrue = Convert.ToBoolean(n);


            // double to char
            double myD = 99.45;
            char ch1 = (char) myD;


            Console.ReadKey();
        }
    }
}
