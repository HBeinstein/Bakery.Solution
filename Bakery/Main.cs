using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Bakery
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to our bakery! We only make bread and pastries. 🥖🍞🥐");
      Console.WriteLine("Bread is $5 a loaf, but if you buy 2, you get one loaf free!");
      Console.WriteLine("Pastries are $2 each, or 2 for $5!");
      Console.WriteLine("How many loaves of bread would you like?");
      int userBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int userPastry = int.Parse(Console.ReadLine());

      Bread breadOrder = new Bread(userBread);
      Pastry pastryOrder = new Pastry(userPastry);

      int breadOrderTotal = breadOrder.TotalPrice();
      int pastryOrderTotal = pastryOrder.TotalPrice();

      Console.WriteLine("Your order total will be $" + (breadOrderTotal + pastryOrderTotal));

      while(true)
      {
        Console.WriteLine("Would you like to add anything to your order?");
        Console.WriteLine("Please enter only bread or pastry");
        string addMore = Console.ReadLine().ToLower();

        if(addMore == "bread") 
        {
          break;
        }
        if(addMore == "pastry")
        {
          break;
        }
      }
    }
  }
}