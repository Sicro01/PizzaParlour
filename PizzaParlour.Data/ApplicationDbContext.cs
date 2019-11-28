using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using PizzaParlour.Data.Models;

namespace PizzaParlour.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        #region Public Properties
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Depth> Depth { get; set; }
        public DbSet<Topping> Topping { get; set; }
        #endregion
    }
}
