using System;
using static System.Console;
using System.Globalization;
class SalesTransactionDemo
{

    static void Main()
    {
        // Write your main here.
    }
    public static void Display(SalesTransaction s)
    {
        // Write your Display() method here.
    }
    public static void DisplayTotal(SalesTransaction s)
    {
        // Write your DisplayTotal() method here.
    }

}

class SalesTransaction
{
    public string Name;
    public double SalesAmount;
    public double Commission;
    public double rate;
    public SalesTransaction()
    { }
    public SalesTransaction(string nameIn, double salesAmountIn, double rateIn)
    {
        NAME_SETGET = nameIn;
        SALESAMOUNT_SETGET = salesAmountIn;
        setRate = rateIn;
        Commission = SALESAMOUNT_SETGET * setRate;
    }
    public SalesTransaction(string nameIn, double salesAmountIn)
    {
        NAME_SETGET = nameIn;
        SALESAMOUNT_SETGET = salesAmountIn;
        setRate = 0;
    }
    public SalesTransaction(string nameIn)
    {
        NAME_SETGET = nameIn;
        SALESAMOUNT_SETGET = 0;
        setRate = 0;
    }
    public SalesTransaction(double salesAmountIn)
    {
        SALESAMOUNT_SETGET = salesAmountIn;
    }
        public double getRate()
    {
        return rate;
    }
    public string NAME_SETGET { get { return Name; } set { Name = value; } }
    public double SALESAMOUNT_SETGET { get { return SalesAmount; } set { SalesAmount = value; } }
    public double setRate { get { return rate; } set { rate = value; } }
    public double COMMISSION_SETGET { get { return Commission; } }

    public static SalesTransaction operator +(SalesTransaction complex1, SalesTransaction complex2)
    {
        
        return new SalesTransaction((complex1.SalesAmount + complex2.SalesAmount));
    }
}
