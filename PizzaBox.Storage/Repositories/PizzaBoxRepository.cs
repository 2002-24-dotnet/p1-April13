using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class PizzaBoxRepository
  {
    private PizzaBoxDbContext _db;

    public PizzaBoxRepository(PizzaBoxDbContext dbContext)
    {
      _db = dbContext;
    }

    public IQueryable<T> Read<T>() where T : class, IEntity
    {
      return _db.Set<T>();
    }

    public T GetFromId<T>(long id) where T : class, IEntity
    {
      // return table.Find(id);
      return _db.Set<T>().SingleOrDefault(t => t.Id == id);
    }
    public void Put<T>(T entity) where T : class, IEntity// update
    {
      // table.Attach(entity);
      // _db.Entry(entity).State = EntityState.Modified;

      var p = GetFromId<T>(entity.Id);
      p = entity;
      Save();
    }

    public long Post<T>(T entity) where T : class, IEntity // insert
    {
      _db.Set<T>().Add(entity);
      Save();
      return _db.Set<T>().ToList().Last().Id;
    }

    public void Delete<T>(long id) where T : class
    {
      T exisiting = _db.Set<T>().Find(id);
      _db.Set<T>().Remove(exisiting);
      Save();
    }

    public void Save()
    {
      // _db.SaveChanges() == 1;
      _db.SaveChanges();
    }

    // public object CheckAccount(string user, string pass)
    // {
    //   return new object();
    // }
  }
}
