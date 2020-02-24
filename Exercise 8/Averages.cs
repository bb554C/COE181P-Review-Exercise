using static System.Console;
public class Averages
{
	public static void Main()
	{

	}
	public static void Average(double one, double two)
	{
		double average = 0.00;
		average = (one + two) / 2;
		Write("{0} {1}  -- Average is {2}", one,two,average);
	}
	public static void Average(double one, double two, double three)
	{
		double average = 0.00;
		average = (one + two + three) / 3;
		Write("{0} {1} {2}  -- Average is {3}", one, two,three, average);
	}
	public static void Average(double[] array)
	{
		double average = 0.00;
		double sum = 0;
			for(int i = 0;i<array.Length;i++)
		sum = sum + array[i];
		average = sum / array.Length;
			for(int i = 0;i<array.Length;i++)
		Write(array[i] + " ");
		Write(" -- Average is {0}", average);
	}
}
