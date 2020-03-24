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
              return View("Store", s);
            }
          else
            return View(account);
        }
      }
      return View(account);
    }
    
    
    [HttpGet]
    public IActionResult History()
    {
      return View("Store");
    }
  }
}
