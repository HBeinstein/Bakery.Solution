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

    [TestMethod]
    public void TotalPrice_CalcTotalPriceBreadOrder_True()
    {
      int testTotalPrice = 15;
      Bread breadTest = new Bread(4);
      int breadTestTotalPrice = breadTest.TotalPrice();
      Assert.AreEqual(testTotalPrice, breadTestTotalPrice);
    }

    [TestMethod]
    public void UpdateTotalAmount_NewTotalBreadPriceAfterAdding_True()
    {
      int testTotalPrice = 15;
      Bread breadTest = new Bread(3);
      int breadTestTotalPrice = breadTest.UpdateTotalAmount(1);
      Assert.AreEqual(testTotalPrice, breadTestTotalPrice);
    }
  }
}