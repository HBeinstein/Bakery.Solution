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
    public void Bread_InstantiateBreadObjWithPriceAndAmount_True()
    {
      int testPrice = 2;
      int testAmount = 2;
      Pastry pastryTest = new Pastry(3);
      int pastryTestPrice = pastryTest.Price;
      int pastryTestAmount = pastryTest.Amount;
      Assert.AreEqual(testPrice, pastryTestPrice);
      Assert.AreEqual(testAmount, pastryTestAmount);
    }
  }
}