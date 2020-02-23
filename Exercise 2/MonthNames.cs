using System;
using static System.Console;
class MonthNames
{
	enum Month
	{
        January=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December

	}
	static void Main()
	{
		string numString = ReadLine();
		int num = Convert.ToInt32(numString);
		WriteLine((Enum.GetName(typeof(Month), num)).ToString());
	}
}
