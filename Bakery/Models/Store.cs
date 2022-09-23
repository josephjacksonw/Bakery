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
    public int Dealamount { get; set; }//how many needed to get a deal
    public int Dealprice { get; set; } // how much that deal costs

    public int cost(int amount)
    {  
      //Console.WriteLine(this.Name);
      return 0;
    }
  }
}
