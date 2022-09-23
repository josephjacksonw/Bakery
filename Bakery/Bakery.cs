// ui file

using System;
using System.Collections.Generic;

using Store.Models;

namespace Store
{
	public class Program
	{
		public static void Main()
    {
      Food bread = new Food("bread", 5, 3, 10);
      Food pastry = new Food("pastry", 2, 3, 5);
      List<Food> Foods = new List<Food>() {bread, pastry};
      Console.WriteLine("Welcome to Pierre's Bakery, bread is $5 a loaf but every 2 you buy, you can get a 3rd for free. Pastries are $2 but you can also buy 3 pastries for $5");

      Console.WriteLine("How many loaves of bread would you like to order?");
      int breadNum = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to order?");
      int pastryNum = Convert.ToInt32(Console.ReadLine());
      int orderTotal = bread.cost(breadNum) + pastry.cost(pastryNum);
      Console.WriteLine("Your order of " + breadNum + " loaves and " + pastryNum + " pastries is: $" + orderTotal);

      /*
      Replacer variable = new Replacer();
      bool buul = true;
      while (buul)
      {
        buul = false;
        Console.WriteLine("would you like the (s)erious changer or the (f)unny changer?");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "s" || answer.ToLower() == "serious")
        {
          Console.WriteLine(variable.changer(phrase, oldWord, newWord));
        }
        else if (answer.ToLower() == "f" || answer.ToLower() == "funny")
        {
          Console.WriteLine(variable.funnyChanger(phrase, oldWord, newWord));
        }
        else 
        {
          Console.WriteLine("sorry, please enter s of f for serious or funny");
          buul = true;
        }
      }*/
    }
  }
}
