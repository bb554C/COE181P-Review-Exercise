using System;
using static System.Console;
class CheckMonth
{
   static void Main()
   {
            bool valid = false;
            int num = Convert.ToInt32(ReadLine());
            if (num >= 1 && num <= 12)
                valid = true;
            if (valid)
                WriteLine(num + " is a valid month.");
            else
                WriteLine("Invalid month");
   }
}
