// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using System;
using static System.Console;
using System.Globalization;
class DebugNine2
{
    static void Main()
    {
        //Display the info about breakfast
        Breakfast special = new Breakfast("French toast", 4.99);
        WriteLine(special.INFO);
        // then display today's special
        WriteLine("Today we are having {0} for {1}",
           special.Name, special.Price.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
    }
}
class Breakfast
{
    public string INFO = "Breakfast is the most important meal of the day.";
    private string name;
    private double price;
    // Breakfast constructor requires a
    // name, e.g "French toast", and a price
    public Breakfast()
    { }
    public Breakfast(string nameIn, double priceIn)
    {
        name = nameIn;
        price = priceIn;
    }
    public string Name { get { return name; } set { name = value; } }
    public double Price { get { return price; } set { price = value; } }
}
