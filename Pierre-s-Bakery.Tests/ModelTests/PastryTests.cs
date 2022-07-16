using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastry.Models;

namespace Pastry.Tests
{
  [TestClass]
  public class PastryTests
  {
    // Test methods go here
    [TestMethod]
    public void PastryCost_CostOnePastryNoDiscount_int()
    {
      int pastryQuantity = 1;
      int pastryCost = 2;
      PastryOrders pastryOrder = new PastryOrders(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }

    [TestMethod]
    public void PastryCost_Cost3PastryWithDiscount_int()
    {
      int pastryQuantity = 3;
      int pastryCost = 5;
      PastryOrders pastryOrder = new PastryOrders(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
  }
}