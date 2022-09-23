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
      Food bread = new Food();
      bread.Name = "bread";
      Assert.AreEqual(5, bread.cost(1));
    }
  }
}