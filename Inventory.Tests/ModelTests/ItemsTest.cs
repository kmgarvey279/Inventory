using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inventory.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    public ItemTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=to_do_list_test;";
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      string description = "1973 tin robot";
      Item newItem = new Item(description);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
  }
}
