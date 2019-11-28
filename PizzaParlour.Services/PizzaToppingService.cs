using PizzaParlour.Data;
using PizzaParlour.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaParlour.Service
{
    public class PizzaToppingService : IPizzaTopping
    {
        private readonly ApplicationDbContext _context;

        public PizzaToppingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(PizzaTopping pizzaTopping)
        {
            throw new NotImplementedException();
        }

        public Task Delete(PizzaTopping pizzaTopping)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAll(IEnumerable<PizzaTopping> pizzaToppings)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PizzaTopping> GetAllByPizzaId(int PizzaId)
        {
            return _context.PizzaToppings;    
        }
    }
}
