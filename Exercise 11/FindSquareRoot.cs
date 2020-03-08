using System;
using static System.Console;
class FindSquareRoot
{
	static void Main()
	{
		double sqrt = 0;
		double num;
		try
		{
			Write("Enter a number ");
			num = Convert.ToDouble(ReadLine());
			if(num>=0)
			{
				sqrt = Math.Sqrt(num);
				WriteLine("Square root is {0}", sqrt);
			}
			else
				WriteLine("Error: Number can't be negative.");
		}
		catch(ApplicationException)
		{
			WriteLine("Error: Number can't be negative.");
		}
	}
}
