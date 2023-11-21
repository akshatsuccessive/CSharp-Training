using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
	public delegate void AddDelegate(int x, int y);
	public delegate string GreetDelegate(string str);

	public class Delegate
	{
		public void AddNums(int a, int b)
		{
			Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
		}
		public static string Greet(string name)
		{
			return "Hello " + name;
		}

		public static void Method()
		{
			Delegate obj = new Delegate();

			//obj.AddNums(100, 40);

			//calling a function using a delegate
			AddDelegate ad = new AddDelegate(obj.AddNums);
			ad(100, 40);

			// call a delegate as method
			ad.Invoke(34, 76);

			//string str = Delegate.Greet("Akshat");
			//Console.WriteLine(str);


			GreetDelegate gd = new GreetDelegate(Delegate.Greet);
			string str = gd("Akshat");
			Console.WriteLine(str);

			Console.ReadKey();
		}
	}
}
