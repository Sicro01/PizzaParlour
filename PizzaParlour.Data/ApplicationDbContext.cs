using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using PizzaParlour.Data.Models;

namespace PizzaParlour.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        #region Public Properties

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Depth> Depths { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<PizzaTopping> PizzaToppings { get; set; }

        #endregion
    }
}
