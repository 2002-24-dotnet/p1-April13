using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;
using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PizzaBox.Client.Controllers
{
  public class UserController : Controller
  {
    private PizzaBoxRepository _pbr;
    public UserController(PizzaBoxRepository pRepo)
    {
      _pbr = pRepo;
    }


    [HttpGet]
    public IActionResult UserLogin()
    {
      return View();
    }
    
    [HttpPost]
    public IActionResult UserLogin(LoginViewModel account)
    {
      
      if (ModelState.IsValid)
      {
        // check if user input matches to a record in user/store database
        // TO-DO: need to verify something exists in the table/database before trying to read from it
        // TO-DO: message for when when login information is not found
        foreach (var u in _pbr.Read<User>().ToList())
        {
          if (account.Email.Equals(u.Email, StringComparison.OrdinalIgnoreCase) && account.Password.Equals(u.Password))
            {
              return UserHome(u.Id);
            }
          else
            return View(account);
        }
      }

      return View(account);
    }

    
    [HttpGet, ActionName("UserHome")]
    public IActionResult UserHome(long id)
    {
      if (id == 0L)
      {
        return View("UserLogin");
      }
      return View("User", _pbr.GetFromId<User>(id));
    }
    
    [HttpGet, ActionName("History")]
    public IActionResult History(long id)
    {
      if (id == 0L)
      {
        return View("UserLogin");
      }
      User loadUser = _pbr.GetFromId<User>(id);
      loadUser.Orders = _pbr.Read<Order>().Where(o => o.User.Id.Equals(id)).ToList();

      return View("History", new OrderHistoryViewModel(_pbr, loadUser));
    }

    // Get Reciept from Order Number
    [HttpGet, ActionName("Reciept")]
    public IActionResult Reciept(long user, long order)
    {
      if (order == 0L || user == 0L)
        return View("UserLogin");
      
      Order loadOrder = _pbr.GetFromId<Order>(order);
      loadOrder.User = _pbr.GetFromId<User>(user);
      loadOrder.Pizzas = _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(order)).ToList();
      
      Store store = new Store();
      foreach(var s in _pbr.Read<Store>().ToList())
      {
        if (_pbr.Read<Order>().Where(or => or.Store.Id.Equals(order)) != null)
          store = s;
      }
      loadOrder.Store =  store;
      //_pbr.Read<Order>().Single(or => or.Id.Equals(order)).Store;
      
      return View("Reciept",loadOrder);
    }

    // Show store locations
    [HttpGet]
    public IActionResult StartOrder(long id)
    {
      if (id == 0L)
      {
        return View("UserLogin");
      }

      return View("Locations", new LocationsViewModel()
      {
        UserId = id,
        StoreList = _pbr.Read<Store>().ToList()
      });
    }

    // Start order by adding store and user to order
    [HttpPost]
    public IActionResult StartOrder(LocationsViewModel LVM)
    {
      if(LVM != null)
      {
        if (LVM.UserId != 0L && LVM.StoreId != 0L)
        {
          Store store = _pbr.GetFromId<Store>(LVM.StoreId);
          User user = _pbr.GetFromId<User>(LVM.UserId);

          long OrderId = _pbr.Post<Order>(new Order(_pbr.GetFromId<Store>(LVM.StoreId), _pbr.GetFromId<User>(LVM.UserId)));

          // load order to view
          return View("Order", GetOrderView(LVM.UserId, LVM.StoreId, OrderId));
        }
        else if (LVM.UserId != 0L )
          return View("User", _pbr.GetFromId<User>(LVM.UserId));
        else
          return View("UserLogin");
      }
      return View("Index");
    }

    [HttpGet, ActionName("AddPizza")]
    public IActionResult AddPizza(long user, long store, long order )
    {
      return View("Create", new PizzaViewModel(order, user, store)
      {
        CrustList = _pbr.Read<Crust>().ToList(),
        SizeList = _pbr.Read<Size>().ToList(),
        ToppingList = _pbr.Read<Topping>().ToList()
      });
    }
    // For going back from AddPizza
    [HttpGet]
    public IActionResult Cart(long user, long store, long order)
    {
      return View("Order", GetOrderView(user, store, order));
    }

    // TO-DO: Verify Pizza
    [HttpPost]
    public IActionResult PostPizza(PizzaViewModel pvm)
    {
      string Name = _pbr.GetFromId<Size>(pvm.SizeId).Name + " " + _pbr.GetFromId<Crust>(pvm.CrustId).Name + " with";

      List<PizzaTopping> PizzaToppings = new List<PizzaTopping>();

      // Add Pizza to database to get id
      long id = _pbr.Post<Pizza>(new Pizza{
        Crust = _pbr.GetFromId<Crust>(pvm.CrustId),
        Size = _pbr.GetFromId<Size>(pvm.SizeId),
        Order = _pbr.GetFromId<Order>(pvm.OrderId)
      });

      // to calculate price of pizza
      decimal price = _pbr.GetFromId<Crust>(pvm.CrustId).Price + _pbr.GetFromId<Size>(pvm.SizeId).Price;

      // List of Toppings for PizzaTopping
      List<Topping> toppings = new List<Topping>();
      foreach (var tid in pvm.ToppingsId)
      {
        // add to list of Toppings
        toppings.Add(_pbr.GetFromId<Topping>(tid));
        // Add topping Name to Name for Pizza
        Name = Name + " " + _pbr.GetFromId<Topping>(tid).Name + ",";
        // add pizzatopping to database 
        long ptid = _pbr.Post<PizzaTopping>(new PizzaTopping()
        {
          Topping = _pbr.GetFromId<Topping>(tid),
          Pizza = _pbr.GetFromId<Pizza>(id)
        });
        // list of pizzatoppings for Pizza
        PizzaToppings.Add(_pbr.GetFromId<PizzaTopping>(ptid));

        price += _pbr.GetFromId<Topping>(tid).Price;
      }
      // Remove last , from pizza name
      Name = Name.Remove(Name.LastIndexOf(","));

      // update Pizza
      Pizza UpdatedPizza = _pbr.GetFromId<Pizza>(id);
      UpdatedPizza.PizzaToppings = PizzaToppings;
      UpdatedPizza.Name = Name;
      UpdatedPizza.Price = price;
      _pbr.Put<Pizza>(UpdatedPizza);

      return View("Order", GetOrderView(pvm.UserId, pvm.StoreId, pvm.OrderId));
    }

    // Remove Pizza from order
    [HttpGet, ActionName("Remove")]
    public IActionResult Remove(long user, long store, long order, long pizza)
    {
      List<long> ptdeleteid = new List<long>();

      // delete pizzatoppings in db that was in the pizza
      // TO-DO: verify if any/null
      foreach (PizzaTopping pt in _pbr.Read<PizzaTopping>().Where(pt => pt.Pizza.Id.Equals(pizza)))
      {
        ptdeleteid.Add(pt.Id);
      };
      foreach(var id in ptdeleteid)
      {
        _pbr.Delete<PizzaTopping>(id);
      }

      // delete pizza from db
      _pbr.Delete<Pizza>(pizza);

      // view updated order
      return View("Order", GetOrderView(user, store, order));
    }
    
    // add time stamp to order in database
    [HttpGet, ActionName("Order")]
    public IActionResult Order(long user, long store, long order)
    {
      var o = _pbr.GetFromId<Order>(order);
      o.date = DateTime.Now;
      _pbr.Put<Order>(o);

      Order loadOrder = _pbr.GetFromId<Order>(order);
      loadOrder.User = _pbr.GetFromId<User>(user);
      loadOrder.Pizzas = _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(order)).ToList();
      loadOrder.Store = _pbr.GetFromId<Store>(store);
      return View("Confirmation", loadOrder);
    }

    // TO-DO: check
    [HttpGet, ActionName("Delete")]
    public IActionResult Delete(long user, long store, long order)
    {
      if (order != 0L)
      {
        User u = _pbr.GetFromId<User>(user);

        List<long> PizzasInOrder = new List<long>();
        List<long> PizzasToppingsInOrder = new List<long>();

        if (_pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(order)).ToList() != null && _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(order)).ToList().Any())
        {
          foreach (var p in _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(order)).ToList())
          {
            PizzasInOrder.Add(p.Id);
          } 

          // delete pizzas in order from database
          foreach (var pid in PizzasInOrder)
          {
            foreach (var pt in _pbr.Read<PizzaTopping>().Where(p => p.Pizza.Id.Equals(pid)).ToList())
            {
              PizzasToppingsInOrder.Add(pt.Id);
            }
            _pbr.Delete<Pizza>(pid);
          }
          // delete pizzatoppings from pizzas in order from database
          foreach (var ptid in PizzasToppingsInOrder)
          {
            _pbr.Delete<PizzaTopping>(ptid);
          }
        }

        // delete order from db
        _pbr.Delete<Order>(order);

        return View("User", u);
      }

      return View("Index");
    }

    private OrderViewModel GetOrderView(long user, long store, long order)
    {
      Order loadOrder = _pbr.GetFromId<Order>(order);
      loadOrder.User = _pbr.GetFromId<User>(user);
      loadOrder.Pizzas = _pbr.Read<Pizza>().Where(p => p.Order.Id.Equals(order)).ToList();
      loadOrder.Store = _pbr.GetFromId<Store>(store);
      OrderViewModel OrderView = new OrderViewModel(loadOrder);
      return OrderView;
    }
    
  }

}
