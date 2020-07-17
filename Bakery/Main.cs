using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Bakery
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to our bakery! We only make bread and pastries.");
      Console.WriteLine("How many loaves of bread would you like?");
      int userBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int userPastry = int.Parse(Console.ReadLine());

      Bread breadOrder = new Bread(userBread);
      Pastry pastryOrder = new Pastry(userPastry);

      int breadOrderTotal = breadOrder.TotalPrice();
      int pastryOrderTotal = pastryOrder.TotalPrice();

      Console.WriteLine("Your order total will be $" + (breadOrderTotal + pastryOrderTotal));


      







      // int total = 0;
      // for (let i = 0; i < input; i++) {
      //   if(input % 3) {
      //     total +=
      //   } else {
      //     total +=
      //   }
      //   return total;
      // }
    }
  }
}