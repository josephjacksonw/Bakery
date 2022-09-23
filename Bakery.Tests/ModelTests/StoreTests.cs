// test file

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Store.Models;

namespace Store.Models.Tests
{
  [TestClass]
  public class ItemTester
  {
    [TestMethod]
    public void cost_returnPurchaseCost_True()
    {
      Food bread = new Food("bread", 5, 3, 10);
      Food pastry = new Food("pastry", 2, 3, 5);
      Assert.AreEqual(20, bread.cost(6));
      Assert.AreEqual(12, pastry.cost(7));
    }
  }
}