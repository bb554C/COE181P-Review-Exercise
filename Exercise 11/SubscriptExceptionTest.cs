using System;
using static System.Console;
class SubscriptExceptionTest
{
	static void Main()
	{
		double[] array = {20.3, 44.6, 32.5, 46.7, 89.6,
		67.5, 12.3, 14.6, 22.1, 13.6};
		int index = 0;
		bool indexCheck = false;
		while(index != 99)
		{
			try
			{
				index = Convert.ToInt32(ReadLine());
				if(index != 99)
					Write(array[index] + " ");
				else
					indexCheck = true;
			}
			catch
			{
				WriteLine("Index was outside the bounds of the array");
				indexCheck = true;
			}
		}
	}
}
