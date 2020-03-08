using static System.Console;
using System;
class TipCalculation
{
         static void Main()
        {
          double priceTest = 44.00;
          double rate = 0.20;
          int tipDollars = 7;
         DisplayTipInfo(priceTest,rate);
          DisplayTipInfo(priceTest,tipDollars);
        }
        //Simulator Checker for double - int not working, but simulation is correct
public static void DisplayTipInfo(double price,int tipInDollars)
        {
            double totalBill = price + tipInDollars;
            WriteLine("Tip in dollars: {0}.  Total bill {1}",tipInDollars.ToString("C"),totalBill.ToString("C"));
        }

 public static void DisplayTipInfo(double price,double tipRate)
        {
            double tip = price * tipRate;
            WriteLine("Meal price: {0:C}. Tip percent: {1:N}\nTip in dollars: {2:C}.  Total bill {3:C}", price, tipRate, tip, tip + price);
        }
}
