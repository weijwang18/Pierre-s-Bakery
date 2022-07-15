using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
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
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostThreeBreadWithDiscount_int()
    {
      int breadQuantity = 9;
      int breadCost = 30;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
  }
}