using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  /*
  public class PizzaBoxRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
  {
    public PizzaBoxDbContext _db;
    public DbSet<TEntity> table;
     public PizzaBoxRepository(PizzaBoxDbContext context)
    {
      _db = context;
      table = context.Set<TEntity>();
    }
     public List<TEntity> GetAll()
    {
      return table.ToList();
    }

    public TEntity Get(long id)
    {
      // return table.Find(id);
      return table.SingleOrDefault(t => t.Id == id);
    }

    public bool Put(TEntity entity) // update
    {
      // table.Attach(entity);
      // _db.Entry(entity).State = EntityState.Modified;

      var p = Get(entity.Id);
      p = entity;
      return Save();
    }

    public bool Post(TEntity entity)  // insert
    {
      table.Add(entity);
      return Save();
    }

    public bool Delete(long id)
    {
      TEntity exisiting = table.Find(id);
      table.Remove(exisiting);
      return Save();
    }

    public bool Save()
    {
      return _db.SaveChanges() == 1;
    }
  }
  */
  
  
  public class PizzaBoxRepository
  {
    private PizzaBoxDbContext _db;

    public PizzaBoxRepository(PizzaBoxDbContext dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<T> Read<T>() where T : class
    {
      return _db.Set<T>();
    }

    // public object CheckAccount(string user, string pass)
    // {
    //   return new object();
    // }
  }
}
