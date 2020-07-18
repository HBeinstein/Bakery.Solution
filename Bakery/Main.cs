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

      Console.WriteLine("Would you like to add anything to your order? Enter yes or no");
      string yesOrNo = Console.ReadLine().ToLower();
      
      if(yesOrNo == "yes")
      {
        while(true)
        {
          Console.WriteLine("Please enter only bread or pastry");
          string addMore = Console.ReadLine().ToLower();
          int newBreadOrderTotal = 0;
          int newPastryOrderTotal = 0;

          if(addMore == "bread") 
          { 
            Console.WriteLine("How many loaves of bread do you want to add to your order?");
            int addBreadAmount = int.Parse(Console.ReadLine());
            newBreadOrderTotal = breadOrder.UpdateTotalAmount(addBreadAmount);
            newPastryOrderTotal = pastryOrder.TotalPrice();
            Console.WriteLine("Your order total will be $" + (newBreadOrderTotal + newPastryOrderTotal));
            Console.WriteLine("anything else? yes/no");
            string yesNo = Console.ReadLine().ToLower();
            if (yesNo == "no")
            {
              Console.WriteLine("Your final order total will be $" + (newBreadOrderTotal + newPastryOrderTotal));
              break;
            }
          }
          if(addMore == "pastry")
          {
            Console.WriteLine("How many pastries do you want to add to your order?");
            int addPastryAmount = int.Parse(Console.ReadLine());
            newPastryOrderTotal = pastryOrder.UpdateTotalAmount(addPastryAmount);
            newBreadOrderTotal = breadOrder.TotalPrice();
            Console.WriteLine("Your order total will be $" + (newBreadOrderTotal + newPastryOrderTotal));
            Console.WriteLine("anything else? yes/no");
            string yesNo = Console.ReadLine().ToLower();
            if (yesNo == "no")
            {
              Console.WriteLine("Your final order total will be $" + (newBreadOrderTotal + newPastryOrderTotal));
              break;
            }
          }
        }
      }
      else 
      {
        Console.WriteLine("Your final order total will be $" + (breadOrderTotal + pastryOrderTotal));
      }
    }
  }
}