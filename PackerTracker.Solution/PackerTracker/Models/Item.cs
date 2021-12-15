using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }

    public string Description { get; set; }
        
    public int Price { get; set; }

    public double Weight { get; set; }

    public string Owned { get; set; }    

    public int Id { get; }

    private static List<Item> _instances = new List<Item> {};

    public Item(string name, string description,  int price, double weight, string owned)
    {
      Name = name;
      Description = description;      
      Price = price;
      Weight = weight;
      Owned = owned;     
      
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}