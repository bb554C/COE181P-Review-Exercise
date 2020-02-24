using static System.Console;
using System;
class InputMethodDemo2
{
	static void Main()
	{
		int first, second;
		first = DataEntry("first");
		second = DataEntry("second");
		WriteLine("After InputMethod first is {0}", first);
		WriteLine("and second is {0}", second);
	} 
	private static int InputMethod()
	{
		int i;
		string str;
		str = ReadLine();
		i = Convert.ToInt32(str);
		return i;
	}

	public static int DataEntry(string whichOne)
	{
		int x;
		Write("Enter {0} integer ",whichOne);
		x = InputMethod();
		return x;
	}
}
