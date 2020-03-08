using System;
using static System.Console;
class SwimmingWaterTemperature
{
	static void Main()
	{
		int tmp = 0;
		bool comfort;
		while(tmp != 999)
		{
			tmp = Convert.ToInt32(ReadLine());
			comfort = CheckComfort(tmp);
			if(comfort)
				WriteLine("Enter another temperature or 999 to quit");
		}
	}

	public static bool CheckComfort(int temp)
	{
		bool test = false;
		try
		{
			if(temp >= 70 && temp <= 85)
			{
				WriteLine("{0} degrees is comfortable for swimming.", temp);
				test = true;
			}
			else if(temp >= 32 && temp <= 212)
			{
				WriteLine("{0} degrees is not comfortable for swimming.", temp);
				test = true;
			}
			else if(temp != 999)
			{
				WriteLine("Value does not fall within the expected range. ");
				test = true;
			}
			else if(temp == 999)
				test = false;

		}
		catch(ArgumentException)
		{
			WriteLine("Value does not fall within the expected range. ");
			test = true;
		}
		return test;
	}
}
