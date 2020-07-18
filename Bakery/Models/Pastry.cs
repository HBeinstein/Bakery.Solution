using System;

namespace Bakery.Models
{
  public class Pastry
  {
    // properties
    public int Price { get; set; }
    public int Amount { get; set; }

    // constructor
    public Pastry(int amount)
    {
        Price = 2;
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
        else 
        {
          total = total + (Price/2);
        }
      }
      return total;
    } 


  }
}