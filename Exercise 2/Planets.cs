using System;
using static System.Console;
class Planets
{
   enum Planet
        {
            MERCURY=1,
            VENUS,
            EARTH,
            MARS,
            JUPITER,
            SATURN,
            URANUS,
            NEPTUNE
        }
   static void Main()
   {
     String numStr = ReadLine();
            int num = Convert.ToInt32(numStr);
            WriteLine((Enum.GetName(typeof(Planet), num)).ToString() + " is " + num.ToString() + " planet(s) from the sun");
   }
}
