using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  public class StoreController : Controller
  {
    public Store CurrentStore;
    private PizzaBoxRepository _pbr;

    public StoreController(PizzaBoxRepository pRepo)
    {
      _pbr = pRepo;
    }
    
    [HttpGet]
    public IActionResult StoreLogin()
    {
      return View();
    }

    [HttpPost]
    public IActionResult StoreLogin(LoginViewModel account)
    {
      if (ModelState.IsValid)
      {
        foreach (var s in _pbr.Read<Store>().ToList()/*StoreRepository.GetAll()*/)
        {
          if (account.Email.Equals(s.Email, StringComparison.OrdinalIgnoreCase) && account.Password.Equals(s.Password))
            {
              CurrentStore = s;
              return StoreHome(s.Id);
            }
        }
      }
      return View(account);
    }
    
    [HttpGet, ActionName("StoreHome")]
    public IActionResult StoreHome(long id)
    {
      if (id == 0L)
      {
        return View("StoreLogin");
      }
      return View("Store", _pbr.GetFromId<Store>(id));
    }


    [HttpGet, ActionName("StoreHistory")]
    public IActionResult StoreHistory(long id)
    {
      if (id == 0L)
      {
        return View("UserLogin");
      }
      Store loadStore = _pbr.GetFromId<Store>(id);
      loadStore.Orders = _pbr.Read<Order>().Where(o => o.Store.Id.Equals(id)).ToList();

      return View("StoreHistory", new StoreHistoryViewModel(_pbr, loadStore));
    }

    // Get Reciept from Order Number
    [HttpGet, ActionName("RecieptCopy")]
    public IActionResult RecieptCopy(long store, long order)
    {
      if (order == 0L || store == 0L)
        return View("UserLogin");
      
      Order loadOrder = _pbr.GetFromId<Order>(order);
      loadOrder.Store = _pbr.GetFromId<Store>(store);
      loadOrder.Pizzas = _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(order)).ToList();
      
      User user = new User();
      foreach(var u in _pbr.Read<User>().ToList())
      {
        if (_pbr.Read<Order>().Where(or => or.User.Id.Equals(u.Id) && or.Id.Equals(order)).Any())
          user = u;
      }
      loadOrder.User =  user;
      //_pbr.Read<Order>().Single(or => or.Id.Equals(order)).Store;
      
      return View("RecieptCopy",loadOrder);
    }
  }
}
