using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    [BindRequired]
    public long OrderId { get; set; }
    [BindRequired]
    public long UserId { get; set; }
    [BindRequired]
    public long StoreId { get; set; }

    [BindNever]
    public Order Order { get; set; }

    public OrderViewModel(Order o)
    {
      Order = o;
      OrderId = o.Id;
      UserId = o.User.Id;
      StoreId = o.Store.Id;
    }
    public OrderViewModel()
    {

    }
  }
}
