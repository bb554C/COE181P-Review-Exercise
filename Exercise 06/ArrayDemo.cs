using System;
using static System.Console;
class ArrayDemo
{
    static void Main()
    {
        int[] nums = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
        int x = 0;
        while (x != 4)
        {
            x = Convert.ToInt32(ReadLine());
            switch (x)
            {
                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        Write(nums[i] + " ");
                    }
                    break;
                case 2:
                    for (int i = 9; i >= 0; i--)
                    {
                        Write(nums[i] + " ");
                    }
                    break;
                case 3:
                    x = Convert.ToInt32(ReadLine());
                    Write(nums[x] + " ");
                    break;
                default:
                    break;
            }
        }
    }
}
