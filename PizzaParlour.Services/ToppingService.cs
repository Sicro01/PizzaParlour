using PizzaParlour.Data;
using PizzaParlour.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaParlour.Service
{
    public class ToppingService : ITopping
    {
        private readonly ApplicationDbContext _context;
        public ToppingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Topping> GetAll()
        {
            return _context.Toppings;
        }

        public Topping GetById(int Id)
        {
            var size = _context.Toppings.Where(t => t.Id == Id).FirstOrDefault();

            return size;
        }
    }
}
