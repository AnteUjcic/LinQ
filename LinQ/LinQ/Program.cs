using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		
		IList<string> stringList = new List<string>() {
			"hamburger",
			"cheese Burger",
			"cheese Burek",
			"Piletina s cheese" ,
			"Shrek"
		};

		
		var result = from s in stringList
					 where s.Contains("cheese")
					 select s;

		foreach (var str in result)
		{
			Console.WriteLine(str);
		}
	}
}

