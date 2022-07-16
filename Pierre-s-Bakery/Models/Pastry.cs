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
        int pastryCost = 0;
        if (Quantity % 3 == 0)
        {
          pastryCost += (Quantity / 3) * 5;
        }
        else 
        {
          int remainder = Quantity % 3;
          pastryCost += (Quantity / 3) * 5 + remainder * _Price;
        }
    // properties, constructors, methods, etc. go here
      return pastryCost;
      }
  }
}
