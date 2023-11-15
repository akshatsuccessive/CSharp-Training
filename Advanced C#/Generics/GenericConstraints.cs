using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int a, int b)
        {
            X = a;
            Y = b;
        }
    }
    class MyStruct<T> where T : struct                // generic constraints
    {
        private T myPoint;

        public MyStruct(T val1)
        {
            myPoint = val1;
        }

        public T GetPoints()
        {
            return myPoint;
        }
    }
    class GenericConstraints
    {
        public static void Method()
        {
            Point P = new Point(10, 20);

            MyStruct<Point> obj = new MyStruct<Point>(P);

            Console.WriteLine("(X, Y) : ({0}, {1})", obj.GetPoints().X, obj.GetPoints().Y);

            Console.ReadKey();
        }
    }
}
