using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Inventory.Models
{

  public class Collection
  {
    private static List<Collection> _instances = new List<Collection> {};
    public string _name;
    public int _id;
    private List<Item> _items;

    public Collection(string collectionName)
    {
      _name = collectionName;
      _instances.Add(this);
      _id = _instances.Count;
      _items = new List<Item> {};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public void AddItem(Item item)
    {
      _items.Add(item);
    }

    public static List<Collection> GetAll()
    {
      return _instances;
    }

    public static Collection Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<Item> GetItems()
    {
      return _items;
    }

  }
}
