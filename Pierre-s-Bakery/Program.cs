using System;
using System.Collections.Generic;
using Bread.Models;
using Pastry.Models;

namespace Program.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to Our Bakery.");
      Console.WriteLine("Please take a look at our menu~");
      ViewTheMenu();
    }
      static void ViewTheMenu(){
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Bread: $5 per loaf. Buy 2, get 1 free!");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5!");
      Console.WriteLine("Would you like to buy Bread or Pastry? (bread/pastry)");
      string stringAnswer = Console.ReadLine();
      string answer = stringAnswer.Replace(" ","").ToLower();
      if (answer == "bread")
      {
        BuyBread();
      } else if (answer == "pastry")
      {
        BuyPastry();
      } else
      {
        Console.WriteLine("Please enter bread or pastry.")
      }


    }
  }
}