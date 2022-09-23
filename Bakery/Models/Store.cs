// business file
/*


*/

using System;
using System.Collections.Generic;



namespace Store.Models
{
  public class Food
  {
    public string Name { get; set; } // bread and pastry goes here
    public int Price { get; set; } //individual item price
    public int DealAmount { get; set; }//how many needed to get a deal
    public int DealPrice { get; set; } // how much that deal costs

    public int cost(int amount)
    {  
      Console.WriteLine(this.Name);
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
    public Food(string name, int price, int dealAmount, int dealPrice)
    {
      Name = name;
      Price = price;
      DealAmount = dealAmount;
      DealPrice = dealPrice;
    }
  }
}
