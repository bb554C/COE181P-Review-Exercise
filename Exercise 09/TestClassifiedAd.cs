using static System.Console;
using System.Globalization;
public class TestClassifiedAd
{
    public static void Main()
    {
        ClassifiedAd myClassifiedAd = new ClassifiedAd("Used Cars", 100);
        ClassifiedAd yourClassifiedAd = new ClassifiedAd("Help Wanted", 60);

    }
}
class ClassifiedAd
{
    private string category;
    private int words;
    private double price;
    private double pricePerWord = 0.09;
    public ClassifiedAd() { }
    public ClassifiedAd(string CategoryIn, int WordsIn)
    {
        Category = CategoryIn;
        Words = WordsIn;
        price = Price;
        Output();
    }
    public void Output()
    {
        WriteLine("The classified ad with {0} words in category {1} costs {2}", Words,Category, Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));

    }
    public string Category { get { return category; } set { category = value; } }
    public int Words { get { return words; } set { words = value; } }
    public double Price
    {
        get
        {
            price = words * pricePerWord;
            return price;
        }
    }
}
