using System.Collections.Generic;

namespace Bakery.Models 
{

  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Item { get; set; }
    public int Id { get; }


    public Order(string orderItem)
    {
      Item = orderItem;
      _instances.Add(this);
      Id = _instances.Count;
    }

      public static void ClearAll()
    {
      _instances.Clear();
    }

  }

}