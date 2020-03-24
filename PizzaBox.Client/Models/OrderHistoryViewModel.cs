using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class OrderHistoryViewModel
  {
    private PizzaBoxRepository _pbr;
    public User CurrentUser { get; set; }

    public OrderHistoryViewModel(PizzaBoxRepository repository, User u)
    {
      _pbr = repository;
      CurrentUser = u;
      UserOrders = new List<Order>();
      // check if order database is empty
      if (CurrentUser.Orders.Any())
      {
        // load pizzas
        foreach (var o in CurrentUser.Orders)
        {
          Order order = o;
          order.Pizzas = _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(o.Id)).ToList();
          //order.Store = _pbr.Read<Order>().Single(or => or.Id.Equals(o.Id)).Store;
          Store store = new Store();
          foreach(Store s in _pbr.Read<Store>().ToList())
          {
            if (_pbr.Read<Order>().Where(or => or.Store.Id.Equals(s.Id) && or.Id.Equals(o.Id)).Any())
              store = s;
          }
          //Store s = _pbr.Read<Store>().Single(s => s.Orders.SingleOrDefault(or =>or.Id.Equals(o.Id)).Equals(o.Id));
          order.Store = store;
          //_pbr.Read<Store>().Where(o => o.Orders.ToList().Equals(id)).ToList();

          UserOrders.Add(order);
        }
      }
    }
    // For Display
    public List<Order> UserOrders { get; set; }


    public OrderHistoryViewModel()
    {
      
    }

  }
}
