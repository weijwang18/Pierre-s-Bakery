using System;
using System.Collections.Generic;

namespace Pastry.Models
{
  public class PastryOrders
  {
      private static int _Price = 2;
      public int Quantity { get; set; }
      
      public static int Price
      {
          get { return _Price; }
          set { _Price = value; }
      }

      public PastryOrders(int quantity)
      {
          _Price = Price;
          Quantity = quantity;
      }

     public int PastryCost()
     {
      int pastryCost = _Price * Quantity;
      return pastryCost;
    // properties, constructors, methods, etc. go here
    }
  }
}