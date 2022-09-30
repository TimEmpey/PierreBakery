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
      Vendor newVendor = new Vendor("testing", "testing");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  [TestMethod]
  public void VendorName_ReturnsVendorsName_String()
  {
    string name = "Lenny's Bakery";
    string location = "Corner of 24th and Jefferson";
    Vendor newVendor = new Vendor(name, location);
    string nameCheck = newVendor.Name;
    Assert.AreEqual(nameCheck, name);
  }

  [TestMethod]
  public void VendorLocation_ReturnsVendorsLocation_String()
  {
    string name = "Lenny's Bakery";
    string location = "Corner of 24th and Jefferson";
    Vendor newVendor = new Vendor(name, location);
    string locationCheck = newVendor.Location;
    Assert.AreEqual(locationCheck, location);
  }

  [TestMethod]
  public void VendorConstructor_SaveMultipleVendorsAndReturnOne_String()
  {
    string nameOne = "Lenny's Bakery";
    string nameTwo = "Sues Cafe";
    string locationOne = "Corner of 24th and Jefferson";
    string locationTwo = "12th Ave";
    Vendor vendorOne = new Vendor(nameOne, locationOne);
    Vendor vendorTwo = new Vendor (nameTwo, locationTwo);
    Assert.AreNotEqual(vendorOne, vendorTwo);
  }

    [TestMethod]
  public void AssignId_AssignAndCheckVendorId_Int()
  {
    string name = "Lenny's Bakery";
    string location = "Corner of 24th and Jefferson";
    Vendor newVendor = new Vendor(name, location);
    int result = newVendor.Id;
    Assert.AreEqual(result, newVendor.Id);
  }

    [TestMethod]
  public void SearchId_VerifyIdsAreNotSame_Bool()
  {
    string name = "Lenny's Bakery";
    string location = "Corner of 24th and Jefferson";
    string nameTwo = "Jewl's Cafe";
    string locationTwo = "192nd Ave";
    Vendor newVendor = new Vendor(name, location);
    Vendor newVendorTwo = new Vendor(nameTwo, locationTwo);
    Assert.AreNotEqual(newVendorTwo.Id, newVendor.Id);
  }

  }
}