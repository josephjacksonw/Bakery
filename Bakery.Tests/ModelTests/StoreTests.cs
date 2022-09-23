using Microsoft.VisualStudio.TestTools.UnitTesting;

using Store.Models;

namespace Store.Models.Tests
{
  [TestClass]
  public class ItemTester
  {
    [TestMethod]
    public void cost_returnBreadCost_True()
    {
      Bread bread = new Bread("bread", 5, 3, 10);
      
      Assert.AreEqual(20, bread.cost(6));
      
    }
    [TestMethod]
    public void cost_returnPastryCost_True()
    {
      Pastry pastry = new Pastry("pastry", 2, 3, 5);
      Assert.AreEqual(12, pastry.cost(7));
    }
  }
}