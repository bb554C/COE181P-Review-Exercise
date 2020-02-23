using System;
using static System.Console;
class WebAddress
{
	static void Main()
	{
		const string www = "www.";
		const string com = ".com";
		string websiteName = ReadLine();
		websiteName = websiteName.Replace(" ", String.Empty);
		WriteLine(www + websiteName + com);
   }
}
