// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
using static System.Console;
class DebugFive3
{
	static void Main()
	{
		char letter;
		int number;
		int LOW = 0;
		int HIGH = 99;
		int NUMINROW = 20;
		for (letter = 'A'; letter <= 'Z'; ++letter)
		{
			for (number = LOW; number <= HIGH; ++number)
			{
				if (number <= NUMINROW)
				{
					Write("{0}{1} ", letter.ToString(), number.ToString("D2"));
				}
				LOW = LOW + 20;
				NUMINROW = NUMINROW + 20;
			}
			LOW = 0;
			NUMINROW = 20;
		}
    }
}
