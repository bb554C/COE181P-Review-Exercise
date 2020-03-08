using static System.Console;
public class FlexibleArrayMethod
{
	static void Main()
	{
		int[] arr = new int[] { 10, 22, 25};
		DisplayAndSum(arr);
	}
	public static void DisplayAndSum(int[] arr)
	{
		int sum = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			Write(arr[i] + " ");
			sum = sum + arr[i];
		}
		WriteLine();
		WriteLine(sum);
	}
}
