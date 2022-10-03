using Microsoft.VisualStudio.TestTools.UnitTesting;

using Store.Models;

namespace Store.Models.Tests
{
  [TestClass]
  public class ItemTester
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("newBread", 1, 1, 1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("newPastry", 1, 1, 1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void cost_returnsBreadCostWithoutDiscounts_Int()
    {
      Bread newBread = new Bread("newBread", 10, 10, 80);
      Assert.AreEqual(60, newBread.cost(6));
    }

    [TestMethod]
    public void cost_returnsPastryCostWithoutDiscounts_Int()
    {
      Pastry newPastry = new Pastry("newPastry", 1, 8, 5);
      Assert.AreEqual(6, newPastry.cost(6));
    }

    [TestMethod]
    public void cost_returnsBreadCostWithDiscounts_Int()
    {
      Bread newBread = new Bread("newBread", 10, 10, 80);
      Assert.AreEqual(170, newBread.cost(21));
    }

    [TestMethod]
    public void cost_returnsPastryCostWithDiscounts_Int()
    {
      Pastry newPastry = new Pastry("newPastry", 1, 8, 5);
      Assert.AreEqual(11, newPastry.cost(17));
    }
  }
}