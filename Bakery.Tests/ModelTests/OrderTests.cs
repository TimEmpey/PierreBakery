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

  [TestMethod]
  public void OrderName_ReturnsOrdersName_String()
  {
    string Item = "Bread";
    Order newOrder = new Order(Item);
    string ItemCheck = newOrder.Item;
    Assert.AreEqual(ItemCheck, Item);
  }

    [TestMethod]
  public void OrderConstructor_SaveMultipleOrdersAndReturnOne_String()
  {
    string itemOne = "Bread";
    String itemTwo = "Croissants";
    Order orderOne = new Order(itemOne);
    Order orderTwo = new Order (itemTwo);
    Assert.AreNotEqual(orderOne, orderTwo);
  }

    [TestMethod]
  public void AssignId_AssignAndCheckOrderId_Int()
  {
    string item = "Bread";
    Order newOrder = new Order(item);
    int result = newOrder.Id;
    Assert.AreEqual(result, newOrder.Id);
  }

    [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    string item = "Bread";
    Order newOrder = new Order(item);
    List<Order> newList = new List<Order> { newOrder };
    string name = "Lenny's Bakery";
    Vendor newVendor = new Vendor(name);
    newVendor.AddOrder(newOrder);
    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
  }

  }
}