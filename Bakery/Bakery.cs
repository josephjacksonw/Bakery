// ui file
/*
using System;
using System.Collections.Generic;

using Class.Models;

namespace Class
{
	public class Program
	{
		public static void Main()
    {
      Console.WriteLine("Enter a phrase, the word you would like to replace, and it's replacement");
      Console.WriteLine("Phrase:");
      string phrase = Console.ReadLine();
      Console.WriteLine("Word to replace:");
      string oldWord = Console.ReadLine();
      Console.WriteLine("New Word:");
      string newWord = Console.ReadLine();

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
      }
    }
  }
}
*/