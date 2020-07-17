using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_InstantiateEmptyPastryObj_True()
    {
      Pastry pastryTest = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastryTest.GetType());
    }

    // [TestMethod]
    // public void Bread_InstantiateBreadObjWithPriceAndAmount_True()
    // {
    //   int testPrice = 5;
    //   int testAmount = 2;
    //   Bread breadTest = new Bread(2);
    //   int breadTestPrice = breadTest.Price;
    //   int breadTestAmount = breadTest.Amount;
    //   Assert.AreEqual(testPrice, breadTestPrice);
    //   Assert.AreEqual(testAmount, breadTestAmount);
    // }
  }
}