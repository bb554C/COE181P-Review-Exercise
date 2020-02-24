using System;
using static System.Console;
class Hurricane
{
	static void Main()
	{
		string str = ReadLine();
		int category = GetCategory(Convert.ToInt32(str));
		if (category == 0)
			WriteLine("Not a hurricane");
		else
			Write("Category ");
		Write(category);
	}
	public static int GetCategory(int wind)
	{
		int category = 0;
		if (wind >= 74 && wind <= 95)
			category = 1;
		else if (wind >= 96 && wind <= 110)
			category = 2;
		else if (wind >= 111 && wind <= 129)
			category = 3;
		else if (wind >= 130 && wind <= 156)
			category = 4;
		else if (wind >= 157)
			category = 5;
		else
			category = 0;
		return category;
	}
}
