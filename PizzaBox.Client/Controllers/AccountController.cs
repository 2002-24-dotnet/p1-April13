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
    public IActionResult SignUp()
    {
      return View();
    }

    [HttpPost]
    public IActionResult SignUp(AccountViewModel account)
    {
      
      if (ModelState.IsValid)
      {
        // check if user input matches to a record in user/store database
        // TO-DO: need to verify something exists in the table/database before trying to read from it
        // TO-DO: message for when when login information is not found
        if (account.IsUser)
        {
          // check if email has already been used
          foreach (var u in _pbr.Read<User>().ToList())
          {
            if (account.Email.Equals(u.Email, StringComparison.OrdinalIgnoreCase))
                return View(account);
            else
            {
              _pbr.Post<User>(new User(){
                Name = account.Name,
                Email = account.Email,
                Password = account.Password,
                PhoneNumber = account.PhoneNum,
                Address = account.Address
              });
              return View("Registered");
            }
          }
        }
        else
        {
          // check if email has already been used
          foreach (var s in _pbr.Read<Store>().ToList())
          {
            if (account.Email.Equals(s.Email, StringComparison.OrdinalIgnoreCase))
              return View(account);
            else
            {
              _pbr.Post<Store>(new Store(){
                Name = account.Name,
                Email = account.Email,
                Password = account.Password,
                PhoneNumber = account.PhoneNum,
                Address = account.Address
              });
              return View("Registered");
            }
          }
        }
      }

      return View(account);
    }

    public IActionResult Logout()
    {
      return View();
    }
  }
}
