using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaParlour.Data;
using PizzaParlour.Data.Models;

namespace PizzaParlour.Service
{
    public class PizzaService : IPizza
    {
        private readonly ApplicationDbContext _context;

        public PizzaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pizza> GatAll()
        {
            return _context.Pizzas;
        }

        public Pizza GetById(int Id)
        {
            var pizza = _context.Pizzas.Where(p => p.Id == Id)
                .Include(p => p.PizzaToppings).FirstOrDefault();
            
            return pizza;
        }
    }
}
