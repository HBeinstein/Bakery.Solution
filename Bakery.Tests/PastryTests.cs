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
      Pastry pastryTest = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), pastryTest.GetType());
    }

    [TestMethod]
    public void Pastry_InstantiatePastryObjWithPriceAndAmount_True()
    {
      int testPrice = 2;
      int testAmount = 2;
      Pastry pastryTest = new Pastry(2);
      int pastryTestPrice = pastryTest.Price;
      int pastryTestAmount = pastryTest.Amount;
      Assert.AreEqual(testPrice, pastryTestPrice);
      Assert.AreEqual(testAmount, pastryTestAmount);
    }

    [TestMethod]
    public void TotalPrice_CalcTotalPricePastryOrder_True()
    {
      int testTotalPrice = 4;
      Pastry pastryTest = new Pastry(2);
      int pastryTestTotalPrice = pastryTest.TotalPrice();
      Assert.AreEqual(testTotalPrice, pastryTestTotalPrice);
    }
    
  }
}