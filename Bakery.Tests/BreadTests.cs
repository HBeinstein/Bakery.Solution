using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void Bread_InstantiateBreadObj_True()
    {
      Bread BreadTest = new Bread();
      Assert.AreEqual(typeof(Bread), BreadTest.GetType());
    }
  }
}