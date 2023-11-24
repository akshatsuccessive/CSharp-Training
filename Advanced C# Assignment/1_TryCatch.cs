using System;	
using System.Collections.Generic;			
	
public class Exception_Handling
{
  public static void Main()
	{
		List<int> list = new List<int>();
    list.Add(10);
    list.Add(20);
    list.Add(30);
    list.Add(40);
    Console.WriteLine("Number of items : {0}", list.Count);

    try 
    {
        Console.WriteLine("The element at 4th index is : {0}", list[4]);
    }
    catch (ArgumentOutOfRangeException e) 
    {
        Console.WriteLine(e.Message);
    }
	}
}
