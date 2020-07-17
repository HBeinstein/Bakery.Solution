using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_InstantiateEmptyBreadObj_True()
    {
      Bread breadTest = new Bread(3);
      Assert.AreEqual(typeof(Bread), breadTest.GetType());
    }

    [TestMethod]
    public void Bread_InstantiateBreadObjWithPriceAndAmount_True()
    {
      int testPrice = 5;
      int testAmount = 2;
      Bread breadTest = new Bread(2);
      int breadTestPrice = breadTest.Price;
      int breadTestAmount = breadTest.Amount;
      Assert.AreEqual(testPrice, breadTestPrice);
      Assert.AreEqual(testAmount, breadTestAmount);
    }
  }
}