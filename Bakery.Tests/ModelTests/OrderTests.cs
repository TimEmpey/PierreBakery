using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{

  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

  [TestMethod]
  public void OrderConstructor_TestIntanceOfOrder_Order()
  {
    Order newOrder = new Order("testing");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }



  }
}