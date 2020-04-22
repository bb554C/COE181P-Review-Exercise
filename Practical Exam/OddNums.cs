using static System.Console;
class OddNums
{
    static void Main()
    {
        int x;
        for (int i = 0; i < 100; i++)
        {
            x = i % 2;
            if(x > 0)
            {
                WriteLine(i);
            }
        }
    }
}
