using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    [BindNever]
    public List<Crust> CrustList { get; set; }
    [BindNever]
    public List<Size> SizeList { get; set; }
    [BindNever]
    public List<Topping> ToppingList { get; set; }

    [BindRequired]
    public long OrderId { get; set; }
    [BindRequired]
    public long UserId { get; set; }
    [BindRequired]
    public long StoreId { get; set; }
    [BindProperty]
    public long CrustId { get; set; }
    [BindRequired]
    public long SizeId { get; set; }
    [BindRequired]
    public IList<long> ToppingsId { get; set; }

    public PizzaViewModel(long orderid, long userid, long storeid)
    {
      OrderId = orderid;
      UserId = userid;
      StoreId = storeid;

      ToppingsId = new List<long>();
    }
    public PizzaViewModel()
    {

    }
  }
}
