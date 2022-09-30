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
    string description = "Corner of 24th and Jefferson";
    Vendor newVendor = new Vendor(name, description);
    string nameCheck = newVendor.Name;
    Assert.AreEqual(nameCheck, name);
  }

  [TestMethod]
  public void VendorDescription_ReturnsVendorsDescription_String()
  {
    string name = "Lenny's Bakery";
    string description = "Corner of 24th and Jefferson";
    Vendor newVendor = new Vendor(name, description);
    string descriptionCheck = newVendor.Description;
    Assert.AreEqual(descriptionCheck, description);
  }

  [TestMethod]
  public void VendorConstructor_SaveMultipleVendorsAndReturnOne_String()
  {
    string nameOne = "Lenny's Bakery";
    string nameTwo = "Sues Cafe";
    string descriptionOne = "Corner of 24th and Jefferson";
    string descriptionTwo = "12th Ave";
    Vendor vendorOne = new Vendor(nameOne, descriptionOne);
    Vendor vendorTwo = new Vendor (nameTwo, descriptionTwo);
    Assert.AreNotEqual(vendorOne, vendorTwo);
  }

    [TestMethod]
  public void AssignId_AssignAndCheckVendorId_Int()
  {
    string name = "Lenny's Bakery";
    string description = "Corner of 24th and Jefferson";
    Vendor newVendor = new Vendor(name, description);
    int result = newVendor.Id;
    Assert.AreEqual(result, newVendor.Id);
  }

    [TestMethod]
  public void SearchId_VerifyIdsAreNotSame_Bool()
  {
    string name = "Lenny's Bakery";
    string description = "Corner of 24th and Jefferson";
    string nameTwo = "Jewl's Cafe";
    string descriptionTwo = "192nd Ave";
    Vendor newVendor = new Vendor(name, description);
    Vendor newVendorTwo = new Vendor(nameTwo, descriptionTwo);
    Assert.AreNotEqual(newVendorTwo.Id, newVendor.Id);
  }

  }
}