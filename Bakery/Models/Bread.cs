using System;

namespace Bakery.Models
{
  public class Bread
  {
    // properties
    public int Price { get; set; }
    public int Amount { get; set; }

    // constructor
    public Bread(int amount)
    {
        Price = 5;
        Amount = amount;
    }

    // methods
    public int TotalPrice()
    {
      int total = 0;
      for (int i = 1; i <= Amount; i++)
      {
        if(i % 3 != 0)
        {
          total = total + Price;
        }
      }
      return total;
    } 

  }
}