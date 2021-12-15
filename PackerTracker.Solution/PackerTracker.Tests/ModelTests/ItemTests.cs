using System;
using System.Collections.Generic;
using PackerTracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("thing", "thing is red", 12, 12.5, "Y");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescripton_String()
    {
      string description = "Trusty Old Backpack";
      Item newItem = new Item("thing", description, 12, 12.5, "Y");
      string result = newItem.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Fancy new backpack.";
      Item newItem = new Item("thing", description, 12, 12.5, "Y");
      
      string updatedDescription = "Trusty old backpack.";
      newItem.Description = updatedDescription;
      string result = newItem.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 23;
      Item newItem = new Item("thing", "thing is red", price, 12.5, "Y");
      int result = newItem.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      int price = 1;
      Item newItem = new Item("thing", "thing is red", price, 12.5, "Y");
      
      int updatedPrice = 3;
      newItem.Price = updatedPrice;
      int result = newItem.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Backpack";
      Item newItem = new Item(name, "thing is red", 12, 12.5, "Y");
      string result = newItem.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Backpack";
      Item newItem = new Item(name, "thing is red", 12, 12.5, "Y");
      
      string updatedName = "Crusty old backpack.";
      newItem.Name = updatedName;
      string result = newItem.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetWeight_ReturnsWeight_Int()
    {
      double weight = 20;
      Item newItem = new Item("thing", "thing is red", 12, weight, "Y");
      double result = newItem.Weight;
      Assert.AreEqual(weight, result);
    }

    [TestMethod]
    public void SetWeight_SetWeight_Int()
    {
      double weight = 20;
      Item newItem = new Item("thing", "thing is red", 12, weight, "Y");
      
      double updatedWeight = 31;
      newItem.Weight = updatedWeight;
      double result = newItem.Weight;
      Assert.AreEqual(updatedWeight, result);
    }

    [TestMethod]
    public void GetOwned_ReturnsOwned_String()
    {
      string owned = "Y";
      Item newItem = new Item("thing", "thing is red", 12, 12.5, owned);
      string result = newItem.Owned;
      Assert.AreEqual(owned, result);
    }

    [TestMethod]
    public void SetOwned_SetOwned_String()
    {
      string owned = "Y";
      Item newItem = new Item("thing", "thing is red", 12, 12.5, owned);
      
      string updatedOwned = "N";
      newItem.Owned = updatedOwned;
      string result = newItem.Owned;
      Assert.AreEqual(updatedOwned, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item> { };
      List<Item> result = Item.GetAll();      
      
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string name01 = "Backpack";
      string description01 = "Old, dirty, reliable.";
      int price01 = 25;
      double weight01 = 10;
      string owned01 = "Y";
      string name02 = "Boots";
      string description02 = "Best hiking boots money can buy.";
      int price02 = 70;
      double weight02 = 6;
      string owned02 = "Y";
      Item newItem1 = new Item(name01, description01, price01, weight01, owned01);
      Item newItem2 = new Item(name02, description02, price02, weight02, owned02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };
      List<Item> result = Item.GetAll();
      
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string name = "Backpack";
      string description = "Old, dirty, reliable.";
      int price = 25;
      double weight = 10;
      string owned = "Y";
      Item newItem = new Item(name, description, price, weight, owned);

      int result = newItem.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      string name01 = "Hotsauce";
      string description01 = "really hot sauce";
      int price01 = 12;
      double weight01 = 12.5;
      string owned01 = "Y";
      
      string name02 = "Horseraddish";
      string description02 = "really hot horseraddish";
      int price02 = 13;
      double weight02 = 13.5;
      string owned02 = "N";
    
      Item newItem1 = new Item(name01, description01, price01, weight01, owned01);
      Item newItem2 = new Item(name02, description02, price02, weight02, owned02);
      
      Item result = Item.Find(2);

      Assert.AreEqual(newItem2, result);
    }

    [TestMethod]
    public void ClearInstance_DeletesCorrectItem_Item()
    {
      string name01 = "Hotsauce";
      string description01 = "really hot sauce";
      int price01 = 12;
      double weight01 = 12.5;
      string owned01 = "Y";
      
      string name02 = "Horseraddish";
      string description02 = "really hot horseraddish";
      int price02 = 13;
      double weight02 = 13.5;
      string owned02 = "N";
    
      Item newItem1 = new Item(name01, description01, price01, weight01, owned01);
      Item newItem2 = new Item(name02, description02, price02, weight02, owned02);
    
      Item result = we want to check if an item was deleted
    }
  }
}