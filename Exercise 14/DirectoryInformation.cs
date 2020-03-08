using System;
using static System.Console;
using System.IO;
class DirectoryInformation
{
	static void Main()
	{
		string directory;
		string[] files;
		int x;
		directory = ReadLine();
		while(directory != "end")
		{
			if (Directory.Exists(directory))
			{
				files = Directory.GetFiles(directory);
				if (files.Length >= 0)
				{
					for (x = 0; x < files.Length; ++x)
						WriteLine("  " + files[x]);
				}
			}
			else
				WriteLine("Directory " + directory + " does not exist");
			directory = ReadLine();
		}
	}
}
