using System;
using static System.Console;
class CheckMonth2
{
	static void Main()
	{
		bool validMonth = false;
		bool validDay = false;
		int month = Convert.ToInt32(ReadLine());
		int day = Convert.ToInt32(ReadLine());
		if (month >= 1 && month <= 12)
			validMonth = true;
		if (month == 2 && day >= 1 && day <= 29)
			validDay = true;
		else if(month == 1 || month == 3 || month == 5  || month == 7  || month == 8  || month == 10  || month == 12)
		  if(day >= 1 && day <= 31)
			validDay = true;
		else if(day >= 1 && day <= 30)
		  validDay = true;
		if(validMonth && validDay && ((day == 25 && month == 1) || (day == 29 && month == 2)))
			WriteLine(month + "/" + day + " is a valid birthday.");
		else if (validMonth && validDay)
			WriteLine(month + "/" + day + " is a valid month.");
		else
			WriteLine("Invalid date");
	}
}
