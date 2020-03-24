using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
  public class Order : IEntity
  {
    public long Id { get; set; }
    
    #region NAVIGATIONAL PROPERTIES
    public List<Pizza> Pizzas { get; set; }
    public User User { get; set; }
    public Store Store { get; set; }

    #endregion
    public decimal Price
    {
      get
      {
        decimal price = 0;;
        if (Pizzas == null)
        {
          return price;
        }
        foreach(var p in Pizzas)
        {
          price += p.Price;
        }
        return price;
      }
    }

    public DateTime date { get; set; }

    public Order(Store s, User u)
    {
      Store = s;
      User = u;
    }

    public Order()
    {
      
    }
  }
}