using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inventory.Models;
using System.Collections.Generic;
using System;

namespace Inventory.Test
{
  [TestClass]
  public class CollectionTest : IDisposable
  {

    public void Dispose()
    {
      Collection.ClearAll();
    }

    [TestMethod]
    public void CollectionConstructor_CreatesIstancesOfCollection_Collection()
    {
      string collectionTestName = "test name";
      Collection newCollection = new Collection(collectionTestName);
      Assert.AreEqual(typeof(Collection), newCollection.GetType());
    }

  }
}
