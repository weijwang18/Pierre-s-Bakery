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
      Console.WriteLine("Hello! Welcome to Our Bakery.");
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
        Console.WriteLine("Your total will be $" + newBreadOrder.BreadCost() + "!");
        Console.WriteLine("Would you like to buy some pastries? (yes/no)");
        string selection = Console.ReadLine();
        string answer = selection.Replace(" ","").ToLower();
        if (answer == "yes" || answer == "y" )
        {
          BuyPastry();
        }
        else
        {
          Console.WriteLine("Have a nice day!");
        }
      }
      static void BuyPastry(){
        Console.WriteLine("How many pastries would you like?");
        string stringAnswer = Console.ReadLine();
        int amount = int.Parse(stringAnswer);
        PastryOrders newPastryOrder = new PastryOrders(amount);
        newPastryOrder.PastryCost();
        Console.WriteLine("Your total will be $" + newPastryOrder.PastryCost() + "!");
        Console.WriteLine("Would you like to buy some bread? (yes/no)");
        string selection = Console.ReadLine();
        string answer = selection.Replace(" ","").ToLower();
        if (answer == "yes" || answer == "y" )
        {
          BuyBread();
        }
        else
        {
          Console.WriteLine("Have a nice day!");
      }
    }
  }
}}