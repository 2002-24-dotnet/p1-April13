using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class StoreHistoryViewModel
  {
    private PizzaBoxRepository _pbr;
    public Store CurrentStore { get; set; }

    public StoreHistoryViewModel(PizzaBoxRepository repository, Store s)
    {
      _pbr = repository;
      CurrentStore = s;
      StoreOrders = new List<Order>();
      // check if order database is empty
      if (CurrentStore.Orders.Any())
      {
        // load pizzas
        foreach (var o in CurrentStore.Orders)
        {
          Order order = o;
          order.Pizzas = _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(o.Id)).ToList();
          //order.Store = _pbr.Read<Order>().Single(or => or.Id.Equals(o.Id)).Store;
          User user = new User();
          foreach(User u in _pbr.Read<User>().ToList())
          {
            if (_pbr.Read<Order>().Where(or => or.User.Id.Equals(u.Id)) != null)
              user = u;
          }
          //Store s = _pbr.Read<Store>().Single(s => s.Orders.SingleOrDefault(or =>or.Id.Equals(o.Id)).Equals(o.Id));
          order.User = user;
          //_pbr.Read<Store>().Where(o => o.Orders.ToList().Equals(id)).ToList();

          StoreOrders.Add(order);
        }
      }
    }
    // For Display
    public List<Order> StoreOrders { get; set; }


    public StoreHistoryViewModel()
    {
      
    }

  }
}
