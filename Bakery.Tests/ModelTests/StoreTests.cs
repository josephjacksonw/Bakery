// test file
//test file
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
      //bread.Name = "bread";
      Assert.AreEqual(20, bread.cost(6));
    }
  }
}