using System;				
public class Delegate
{
	// defining a delegate
	public delegate void AddDelegate(int x, int y);
	public delegate string GreetDelegate(string str);
	
	public void AddNums(int a, int b)
	{
		Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
	}
	public static string Greet(string name)
	{
		return "Hello " + name;
	}
	
	public static void Main()
	{
		Delegate obj = new Delegate();

		// calling a function using a delegate
		AddDelegate ad = new AddDelegate(obj.AddNums);
		ad(100, 40);
			
		ad.Invoke(34, 76);

		Console.WriteLine();
		
		GreetDelegate gd = new GreetDelegate(Delegate.Greet);
		string str = gd("Akshat");
		Console.WriteLine(str);
	}
}
