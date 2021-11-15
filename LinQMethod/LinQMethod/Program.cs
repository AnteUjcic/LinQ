using System;
using System.Linq;
using System.Collections.Generic;

namespace LinQMethod
{
    class Program
    {
        static void Main(string[] args)
        {
			
			IList<string> stringList = new List<string>() {
			"Tosted cheese",
			"CHEESE",
			"shrek 101",
			"how 2 be shrek" ,
			"burger shrek"
		};

			
			var result = stringList.Where(s => s.Contains("shrek"));


			foreach (var str in result)
			{
				Console.WriteLine(str);
			}
		}
    }
}
