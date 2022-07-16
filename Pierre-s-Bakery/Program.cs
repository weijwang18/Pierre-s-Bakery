using System;
using System.Collections.Generic;
using Bread.Models;
using Pastry.Models;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to Pierre's Bakery.");
      Console.WriteLine("Please take a look at our menu~");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Bread: $5 per loaf. Buy 2, get 1 free!");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5!");
      Order();
    }
      static void Order(){
      Console.WriteLine("Would you like to buy Bread or Pastry? (bread/pastry)");
      string stringAnswer = Console.ReadLine();
      string answer = stringAnswer.Replace(" ","").ToLower();
      if (answer == "bread")
      {
        BuyBread();
      } else if (answer == "pastry")
      {
        BuyPastry();
      } 
      else
      {
        Console.WriteLine("Please enter bread or pastry.");
        Order();
      }
      static void BuyBread(){
        Console.WriteLine("How many loaves would you like?");
        string stringAnswer = Console.ReadLine();
        int amount = int.Parse(stringAnswer);
        BreadOrders newBreadOrder = new BreadOrders(amount);
        if (amount <= 0)
        {
          Console.WriteLine("Please enter an amount greater than zero.");
          BuyBread();
        } else if (amount == 1) {
          Console.WriteLine(amount + " loaf will cost $" + newBreadOrder.BreadCost() + "!");
        } else {
          Console.WriteLine(amount + " loaves will cost $" + newBreadOrder.BreadCost() + "!");
        }
        Console.WriteLine("Would you like to buy some pastries? (yes/'Enter' to leave)");
        string selection = Console.ReadLine();
        string answer = selection.Replace(" ","").ToLower();
        if (answer == "yes" || answer == "y" )
        {
          BuyPastry();
        }
      }
      static void BuyPastry(){
        Console.WriteLine("How many pastries would you like?");
        string stringAnswer = Console.ReadLine();
        int amount = int.Parse(stringAnswer);
        PastryOrders newPastryOrder = new PastryOrders(amount);
        if (amount <= 0)
        {
          Console.WriteLine("Please enter an amount greater than zero.");
          BuyPastry();
        } else if (amount == 1) {
          Console.WriteLine(amount + " pastry will cost $" + newPastryOrder.PastryCost() + "!");
        } else {
          Console.WriteLine(amount + " pastries will cost $" + newPastryOrder.PastryCost() + "!");
        }
        Console.WriteLine("Would you like to buy some bread? (yes/'Enter' to leave)");
        string selection = Console.ReadLine();
        string answer = selection.Replace(" ","").ToLower();
        if (answer == "yes" || answer == "y" )
        {
          BuyBread();
        }
    }
  }
}}