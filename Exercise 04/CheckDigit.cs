using System;
using static System.Console;
class CheckDigit
{
	static void Main()
	{
		bool valid = false;
		string numStr = ReadLine();
		int num = Convert.ToInt32(numStr);
		int numkey = num % 10;
		num = num/10;
		if ((num % 7) == numkey)
			valid = true;
		if (valid)
			WriteLine("The account number is valid");
		else
			WriteLine("Invalid");
	}
}
