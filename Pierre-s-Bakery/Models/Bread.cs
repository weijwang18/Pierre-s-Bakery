using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class BreadOrders
  {
      private static int _Price = 5;
      public int Quantity { get; set; }
      
      public static int Price
      {
          get { return _Price; }
          set { _Price = value; }
      }

      public BreadOrders(int quantity)
      {
          _Price = Price;
          Quantity = quantity;
      }

     public int BreadCost()
     {
      int breadCost = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index % 3 == 0)
        {
          int remainder = index % 3;
          breadCost -=  _Price * remainder;
        }
        else
        {
          breadCost += _Price;
        }
      }
      return breadCost;
    // properties, constructors, methods, etc. go here
  }
}
}