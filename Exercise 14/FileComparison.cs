using System;
using static System.Console;
using System.IO;
class FileComparison
{
    static void Main()
    {
        long size1, size2;
        FileInfo fileInfo1 = new FileInfo("Quote.txt");
        size1 = fileInfo1.Length;
        FileInfo fileInfo2 = new FileInfo("Quote.docx");
        size2 = fileInfo2.Length;
        WriteLine("The size of the Word file is " + Convert.ToInt32(size2));
        WriteLine("and the size of the Notepad file is " + Convert.ToInt32(size1));
        double x = (Convert.ToDouble(size1) / Convert.ToDouble(size2)) * 100;
        WriteLine("The Notepad file is {0:N2} % of the size of the Word file", x);
    }
}
