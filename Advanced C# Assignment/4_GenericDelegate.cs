using System;					
public class GenericDelegates
{
	// A function to returns the sum of three numbers
	public static double AddNums(int x, float y, double z)
	{
		return x + y + z;
	}

	// A function to print the factorial of a number
	public static void PrintFactorial(int x)
	{
		int fact = 1;
		for(int i = 2; i <= x; i++)
		{
			fact = fact * i;
		}
		Console.WriteLine(fact);
	}

	//  Function returns a true if length of the string is greater than 5
	public static bool CheckLength(string str)
	{
		return str.Length > 5;
	}
	

	public static void Main()
	{
		Func<int, float, double, double> del1 = new Func<int, float, double, double>(AddNums);

		double res = del1(12, 5.82f, 98.883);
		Console.WriteLine(res);

		Action<int> del2 = new Action<int>(PrintFactorial);
		del2(6);

		Predicate<string> del3 = new Predicate<string>(CheckLength);  
		Console.WriteLine(del3("Akshat"));
	}
}
