using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class LocationsViewModel
  {
    [BindProperty]
    public long UserId { get; set; }

    [BindProperty]
    public long StoreId { get; set; }

    [BindNever]
    public List<Store> StoreList { get; set; }
  }
}
