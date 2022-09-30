using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{

  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testing");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  [TestMethod]
  public void VendorName_ReturnsVendorsName_String()
  {
    string name = "Lenny's Bakery";
    Vendor newVendor = new Vendor(name);
    string nameCheck = newVendor.Name;
    Assert.AreEqual(nameCheck, name);
  }

  [TestMethod]
  public void VendorConstructor_SaveMultipleVendorsAndReturnOne_String()
  {
    string nameOne = "Lenny's Bakery";
    String nameTwo = "Sues Cafe";
    Vendor vendorOne = new Vendor(nameOne);
    Vendor vendorTwo = new Vendor (nameTwo);
    Assert.AreNotEqual(vendorOne, vendorTwo);
  }

    [TestMethod]
  public void AssignId_AssignAndCheckVendorId_Int()
  {
    string name = "Lenny's Bakery";
    Vendor newVendor = new Vendor(name);
    int result = newVendor.Id;
    Assert.AreEqual(result, newVendor.Id);
  }

  }
}