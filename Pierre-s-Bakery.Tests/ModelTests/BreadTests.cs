using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bread.Models;

namespace Bread.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
    [TestMethod]
    public void BreadCost_CostOneBreadNoDiscount_int()
    {
      int breadQuantity = 1;
      int breadCost = 5;
      BreadOrders breadOrder = new BreadOrders(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostThreeBreadWithDiscount_int()
    {
      int breadQuantity = 3;
      int breadCost = 10;
      BreadOrders breadOrder = new BreadOrders(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
  }
}