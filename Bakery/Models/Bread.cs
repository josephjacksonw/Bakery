using System;
using System.Collections.Generic;



namespace Store.Models
{
  public class Bread
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public int DealAmount { get; set; }
    public int DealPrice { get; set; }

    public int cost(int amount)
    {  
      int orderCost = 0;
      while (amount >= this.DealAmount)
      {
        amount -= DealAmount;
        orderCost += DealPrice;
      }
      while (amount > 0)
      {
        amount --;
        orderCost += Price;
      }
      return orderCost;
    }
    public Bread(string name, int price, int dealAmount, int dealPrice)
    {
      Name = name;
      Price = price;
      DealAmount = dealAmount;
      DealPrice = dealPrice;
    }
  }
}
