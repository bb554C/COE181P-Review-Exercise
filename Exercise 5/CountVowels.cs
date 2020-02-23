using System;
using static System.Console;
class CountVowels
{
   static void Main()
   {
         int vowel = 0;
            int cons = 0;
            String inputString = ReadLine();
            int len = inputString.Length;
            for (int i = 0; i < len; i++)
            {

                if (inputString[i] == 'a' || inputString[i] == 'e' || inputString[i] == 'i' || inputString[i] == 'o' || inputString[i] == 'u' || inputString[i] == 'A' || inputString[i] == 'E' || inputString[i] == 'I' || inputString[i] == 'O' || inputString[i] == 'U')
                {
                    vowel++;
                }
                else if ((inputString[i] >= 'a' && inputString[i] <= 'z') || (inputString[i] >= 'A' && inputString[i] <= 'Z'))
                {
                    cons++;
                }
            }
            WriteLine(vowel);
   }
}
