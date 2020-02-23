using System;
using static System.Console;
class FahrenheitToCelsius
{
   static void Main()
   {
		double Fahrenheit, Celsius;
		string FahrenheitString;
		FahrenheitString = ReadLine();
		Fahrenheit = Convert.ToDouble(FahrenheitString);
		Celsius = (Fahrenheit - 32) * (5.0 / 9.0);
		WriteLine("{0:0.0} F is {1:0.0} C", Fahrenheit, Celsius);
   }
}
