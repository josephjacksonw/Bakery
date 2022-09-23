using System;
using System.Collections.Generic;

using Store.Models;

namespace Store
{
	public class Program
	{
		public static void Main()
    {
      Bread sourdough = new Bread("Sourdough", 5, 3, 10);
      Pastry bearClaw = new Pastry("Bear Claw", 2, 3, 5);
      Console.WriteLine("Welcome to Pierre's Bakery, bread is $5 a loaf but every 2 you buy, you can get a 3rd for free. Pastries are $2 but you can also buy 3 pastries for $5.");
      Console.WriteLine("How many loaves of sourdough would you like to order?");
      int breadNum = 0;
      bool buul = true;
      while (buul)
      {
        buul = false;
        try
        {
          breadNum = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Sorry that's not an integer number. Enter 0 if you wouldn't like to order any bread");
          buul = true;
        }
        if (breadNum < 0)
        {
          Console.WriteLine("Sorry we can't buy your bread, how many loaves of our bread would you like to buy?");
          buul = true;
          breadNum = 1;//this fixes a bug
        }
      }
      buul = true;
      int pastryNum = 0;
      Console.WriteLine("How many bear claws would you like to order?");
      while (buul)
      {
        buul = false;
        try
        {
          pastryNum = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Sorry that's not an integer number. Enter 0 if you wouldn't like to order any pastries");
          buul = true;
        }
        if (pastryNum < 0)
        {
          Console.WriteLine("Sorry we can't buy your pastries, how many of our pastries would you like to buy?");
          buul = true;
          pastryNum = 1;//this fixes a bug
        }
      }
      int orderTotal = sourdough.cost(breadNum) + bearClaw.cost(pastryNum);
      Console.WriteLine("Your order of " + breadNum + " loaves and " + pastryNum + " bear claws is: $" + orderTotal);
      /*
      Bread multigrain = new Bread("Multigrain", 5, 3, 10);
      Pastry danish = new Pastry("Danish", 2, 3, 5);
      bool firstItem = true;
      int sNum = 0;
      int mNum = 0;
      int bNum = 0;
      int dNum = 0;
      */
      /*
      Console.WriteLine("What baked goods would you like to order?");
      Console.WriteLine("(S)ourdough bread, (M)ultigrain bread, (B)ear claws, or (D)anish?");
      string order = Console.ReadLine().ToLower();
      if (order[0].Equals(testvar))
      {
        if (sNum != 0)
        {
          Console.WriteLine("Your cart already has " + sNum + " loaves of sourdough. How many do you want in your cart?");
        }
        else
        {
          Console.WriteLine("How many loaves of sourdough would you like?");
        }
        sNum = Convert.ToInt32(Console.ReadLine());
      }
      else if (order[0].Equals("m"))
      {
        if (mNum != 0)
        {
          Console.WriteLine("Your cart already has " + mNum + " loaves of multigrain. How many do you want in your cart?");
        }
        else
        {
          Console.WriteLine("How many multigrain loaves would you like?");
        }
        mNum = Convert.ToInt32(Console.ReadLine());
      }
      else if (order[0].Equals("b"))
      {
        if (bNum != 0)
        {
          Console.WriteLine("Your cart already has " + bNum + " bear claws. How many do you want in your cart?");
        }
        else
        {
          Console.WriteLine("How many bear claws would you like?"); 
        }
        bNum = Convert.ToInt32(Console.ReadLine());
      }
      else if (order[0].Equals("d"))
      {
        if (dNum != 0)
        {
          Console.WriteLine("Your cart already has " + dNum + " danishes. How many do you want in your cart?");
        }
        else
        {
          Console.WriteLine("How many danishes would you like?");  
        }
        dNum = Convert.ToInt32(Console.ReadLine());
      }
      */
      
      
      /*
      string theirOrder = "Your order of ";
      if (bNum + sNum + mNum + dNum == 0)
      {
        theirOrder += "nothing";
      }

      theirOrder += " totals to: $" + orderTotal; */
    }
  }
}
