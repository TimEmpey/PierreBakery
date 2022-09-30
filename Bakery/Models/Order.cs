using System.Collections.Generic;

namespace Bakery.Models 
{

  public class Order
  {
    public string Item { get; set; }
    public string Amount { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };


    public Order(string orderItem, string orderAmount, string orderPrice, string orderDate)
    {
      Item = orderItem;
      Amount = orderAmount;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

      public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }

}