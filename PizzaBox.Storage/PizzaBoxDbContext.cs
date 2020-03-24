using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interfaces;
using System;

namespace PizzaBox.Storage
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<User> User { get; set; }
    public DbSet<Store> Store { get; set; }
    public DbSet<Order> Order { get; set; }

    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Crust> Crust { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Topping> Topping { get; set; }
    public DbSet<PizzaTopping> PizzaTopping { get; set; }

    public PizzaBoxDbContext(DbContextOptions options) : base(options)
    {
      //this.Database.Migrate();
    }

    public DbSet<TEntity> SetDbSet<TEntity>() where TEntity : class, IEntity
    {
      return this.Set<TEntity>();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(c => c.Id);
      builder.Entity<Pizza>().HasKey(p => p.Id);
      builder.Entity<PizzaTopping>().HasKey(pt => pt.Id);
      builder.Entity<Size>().HasKey(s => s.Id);
      builder.Entity<Topping>().HasKey(t => t.Id);
      builder.Entity<User>().HasKey(u => u.Id);
      builder.Entity<Store>().HasKey(st => st.Id);
      builder.Entity<Order>().HasKey(o => o.Id);

      builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.Crust);
      builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.Size);


      builder.Entity<Pizza>().HasMany(p => p.PizzaToppings).WithOne(pt => pt.Pizza);
      builder.Entity<Topping>().HasMany(t => t.PizzaToppings).WithOne(pt => pt.Topping);

      builder.Entity<Store>().HasMany(st => st.Orders).WithOne(o => o.Store);
      builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
      builder.Entity<Order>().HasMany(o => o.Pizzas).WithOne(p => p.Order);

      Create(builder);
    }

    void Create(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() { Name = "Deep Dish", Price = 3.50M },
        new Crust() { Name = "New York Style", Price = 2.50M },
        new Crust() { Name = "Thin Crust", Price = 1.50M }
      });

      builder.Entity<Size>().HasData(new Size[]
      {
        new Size() { Name = "Large", Price = 12.00M },
        new Size() { Name = "Medium", Price = 10.00M },
        new Size() { Name = "Small", Price = 8.00M },
      });

      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping() { Name = "Cheese", Price = 0.50M },
        new Topping() { Name = "Pepperoni", Price = 0.75M },
        new Topping() { Name = "Tomato Sauce", Price = 0.50M },
        new Topping() { Name = "Marinara Sauce", Price = 0.50M },
        new Topping() { Name = "Alfredo Sauce", Price = 0.50M },
        new Topping() { Name = "Italian Sausage", Price = 0.75M },
        new Topping() { Name = "Olives", Price = 0.50M },
        new Topping() { Name = "Pineapple", Price = 0.50M },
        new Topping() { Name = "Green Peppers", Price = 0.50M },
        new Topping() { Name = "Spinach", Price = 0.50M }
      });

      builder.Entity<User>().HasData(new User[]
      {
        new User() { Id=DateTime.Now.Ticks, Name="Person1", Email="Person1@mail.com", Password="Password123", Address="123 Main St, Arlington, TX 76543", PhoneNumber="972-123-4567" },
        new User() { Id=DateTime.Now.Ticks, Name="Person2", Email="Person2@mail.com", Password="Password123", Address="321 Main St, Arlington, TX 76543", PhoneNumber="972-321-4567" }
      });

      builder.Entity<Store>().HasData(new Store[]
      {
        new Store() { Id=DateTime.Now.Ticks, Name="Store1", Email="Store1@mail.com", Password="Password123", Address="456 Main St, Arlington, TX 76543", PhoneNumber="817-123-4567" },
        new Store() { Id=DateTime.Now.Ticks, Name="Store2", Email="Store2@mail.com", Password="Password123", Address="789 Main St, Arlington, TX 76543", PhoneNumber="817-654-3210" }
      });
    }

  }
}
