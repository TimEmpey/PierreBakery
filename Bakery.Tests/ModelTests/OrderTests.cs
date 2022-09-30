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
  public void OrderConstructor_TestInstanceOfOrder_Order()
  {
    Order newOrder = new Order("item", "amount", "price", "date");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }

  [TestMethod]
  public void OrderItem_ReturnsOrdersItem_String()
  {
    string Item = "Bread";
    string Amount = "10 loafs";
    string Price = "$50";
    string Date = "Sep 12, 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string ItemCheck = newOrder.Item;
    Assert.AreEqual(ItemCheck, Item);
  }

  [TestMethod]
  public void OrderAmount_ReturnsOrdersAmount_String()
  {
    string Item = "Bread";
    string Amount = "10 loafs";
    string Price = "$50";
    string Date = "Sep 12, 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string amountCheck = newOrder.Amount;
    Assert.AreEqual(amountCheck, Amount);
  }

  [TestMethod]
  public void OrderPrice_ReturnsOrdersName_String()
  {
    string Item = "Bread";
    string Amount = "10 loafs";
    string Price = "$50";
    string Date = "Sep 12, 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string priceCheck = newOrder.Price;
    Assert.AreEqual(priceCheck, Price);
  }

  [TestMethod]
  public void OrderDate_ReturnsOrdersName_String()
  {
    string Item = "Bread";
    string Amount = "10 loafs";
    string Price = "$50";
    string Date = "Sep 12, 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string dateCheck = newOrder.Date;
    Assert.AreEqual(dateCheck, Date);
  }

    [TestMethod]
  public void OrderConstructor_SaveMultipleOrdersAndReturnOne_String()
  {
    string itemOne = "Bread";
    string amountOne = "10 loafs";
    string priceOne = "$50";
    string dateOne = "Sep 12, 2022";
    String itemTwo = "Croissants";
    string amountTwo = "5 bundles";
    string priceTwo = "$30";
    string dateTwo = "Oct 5, 2022";
    Order orderOne = new Order(itemOne, amountOne, priceOne, dateOne);
    Order orderTwo = new Order (itemTwo, amountTwo, priceTwo, dateTwo);
    Assert.AreNotEqual(orderOne, orderTwo);
  }

    [TestMethod]
  public void AssignId_AssignAndCheckOrderId_Int()
  {
    string Item = "Bread";
    string Amount = "10 loafs";
    string Price = "$50";
    string Date = "Sep 12, 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    int result = newOrder.Id;
    Assert.AreEqual(result, newOrder.Id);
  }

    [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    string Item = "Bread";
    string Amount = "10 loafs";
    string Price = "$50";
    string Date = "Sep 12, 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    List<Order> newList = new List<Order> { newOrder };
    string name = "Lenny's Bakery";
    string description = "Corner of 24th and Jefferson";
    Vendor newVendor = new Vendor(name, description);
    newVendor.AddOrder(newOrder);
    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
  }

  }
}