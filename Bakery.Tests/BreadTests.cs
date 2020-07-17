using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void Bread_InstantiateEmptyBreadObj_True()
    {
      Bread breadTest = new Bread();
      Assert.AreEqual(typeof(Bread), breadTest.GetType());
    }

    [TestMethod]
    public void Bread_InstantiateBreadObjWithPriceParam_True()
    {
      int testPrice = 5;
      Bread breadTest = new Bread();
      int breadTestPrice = breadTest.Price;
      Assert.AreEqual(testPrice, breadTestPrice);
    }
  }
}