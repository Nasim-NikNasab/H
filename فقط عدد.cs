using System;

namespace Number;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Enter Number");
		string Number = Console.ReadLine();
		double n1 = Convert.ToDouble(Number);
		double d1 = Convert.ToDouble(n1);
		if (n1 >= 0.0 || n1 <= 0.0)
		{
			Console.WriteLine(n1);
		}
	}
}
