using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  public class AccountController : Controller
  {
    private PizzaBoxRepository _pbr;
    // private PizzaBoxRepository<User> UserRepository;
    // private PizzaBoxRepository<Store> StoreRepository;
    // private static PizzaBoxDbContext Context;

    // public AccountController(PizzaBoxDbContext pContext)
    // {
    //   UserRepository = new PizzaBoxRepository<User>(pContext);
    //   StoreRepository = new PizzaBoxRepository<Store>(pContext);
    //   Context = pContext;
    // }

    public AccountController(PizzaBoxRepository pRepo)
    {
      _pbr = pRepo;
    }

    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(AccountViewModel account)
    {
      if (ModelState.IsValid)
      {
        if (account.IsUser)
        {
          foreach (var u in _pbr.Read<User>().ToList())
          {
            if (account.Email.Equals(u.Email, StringComparison.OrdinalIgnoreCase) && account.Password.Equals(u.Password))
              return View("User", u);
            else
              return View(account);
          }
        }
        else
        {
          foreach (var s in _pbr.Read<Store>().ToList()/*StoreRepository.GetAll()*/)
          {
            if (account.Email.Equals(s.Email, StringComparison.OrdinalIgnoreCase) && account.Password.Equals(s.Password))
              return View("Store", s);
            else
              return View(account);
          }
        }
      }

      // var acct = _pbr.CheckAccount(account.Username, account.Password);

      // if (acct != null)
      // {
      //   if (account.User)
      //   {
      //     return View("User", acct);
      //   }

      //   return View("Store", acct);
      // }

      return View(account);
    }

    public IActionResult Logout()
    {
      return View();
    }
  }
}
