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
      int userBread = Console.ReadLine().Parse();
      Console.WriteLine("How many pastries would you like?");
      int userPastry = Console.ReadLine().Parse();

      Bread breadOrder = new Bread(userBread);
      Pastry pastryOrder = new Pastry(userPastry);
      
    }
  }
}