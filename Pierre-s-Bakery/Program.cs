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
      public static void Order(){
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
      }

      public static void BuyBread(){
        Console.WriteLine("How many loaves would you like?");
        string loavesAnswer = Console.ReadLine();
        int loavesamount = int.Parse(loavesAnswer);
        BreadOrders newBreadOrder = new BreadOrders(loavesamount);
        if (loavesamount <= 0)
        {
          Console.WriteLine("Please enter an amount greater than zero.");
          BuyBread();
        } else if (loavesamount == 1) {
          Console.WriteLine(loavesamount + " loaf will cost $" + newBreadOrder.BreadCost() + "!");
        } else {
          Console.WriteLine(loavesamount + " loaves will cost $" + newBreadOrder.BreadCost() + "!");
        }
        Console.WriteLine("Would you like to buy some pastries? (yes/no)");
        string selection = Console.ReadLine();
        string answer = selection.Replace(" ","").ToLower();
        if (answer == "yes" || answer == "y" )
        {
          Console.WriteLine("How many pastries would you like?");
          string pastriesAnswer = Console.ReadLine();
          int pastriesamount = int.Parse(pastriesAnswer);
          PastryOrders newPastryOrder = new PastryOrders(pastriesamount);
          if (pastriesamount <= 0)
          {
            Console.WriteLine("Please enter an amount greater than zero.");
            BuyPastry();
          } else if (pastriesamount == 1) {
            Console.WriteLine(pastriesamount + " pastry will cost $" + newPastryOrder.PastryCost() + "!");
          } else {
            Console.WriteLine(pastriesamount + " pastries will cost $" + newPastryOrder.PastryCost() + "!");
          }
          Console.WriteLine("Your total is" + " $" + (newPastryOrder.PastryCost() + newBreadOrder.BreadCost()) + "!");
        } else if (answer == "no" || answer == "No") {
          Console.WriteLine("Your total is" + " $" + newBreadOrder.BreadCost() + "!");
        }
      }


      public static void BuyPastry(){
        Console.WriteLine("How many pastries would you like?");
        string pastriesAnswer = Console.ReadLine();
        int pastriesamount = int.Parse(pastriesAnswer);
        PastryOrders newPastryOrder = new PastryOrders(pastriesamount);
        if (pastriesamount <= 0)
        {
          Console.WriteLine("Please enter an amount greater than zero.");
          BuyPastry();
        } else if (pastriesamount == 1) {
          Console.WriteLine(pastriesamount + " pastry will cost $" + newPastryOrder.PastryCost() + "!");
        } else {
          Console.WriteLine(pastriesamount + " pastries will cost $" + newPastryOrder.PastryCost() + "!");
        }
        Console.WriteLine("Would you like to buy some bread? (yes/no)");
        string selection = Console.ReadLine();
        string answer = selection.Replace(" ","").ToLower();
        if (answer == "yes" || answer == "y" )
        {
              Console.WriteLine("How many loaves would you like?");
          string loavesAnswer = Console.ReadLine();
          int loavesamount = int.Parse(loavesAnswer);
          BreadOrders newBreadOrder = new BreadOrders(loavesamount);
          if (loavesamount <= 0)
          {
            Console.WriteLine("Please enter an amount greater than zero.");
            BuyBread();
          } else if (loavesamount == 1) {
            Console.WriteLine(loavesamount + " loaf will cost $" + newBreadOrder.BreadCost() + "!");
          } else {
            Console.WriteLine(loavesamount + " loaves will cost $" + newBreadOrder.BreadCost() + "!");
          }
          Console.WriteLine("Your total is" + " $" + (newPastryOrder.PastryCost() + newBreadOrder.BreadCost()) + "!");
        } else if (answer == "no" || answer == "No") {
          Console.WriteLine("Your total is" + " $" + newPastryOrder.PastryCost() + "!");
        }
    }
  }
}