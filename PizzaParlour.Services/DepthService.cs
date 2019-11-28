using PizzaParlour.Data;
using PizzaParlour.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaParlour.Service
{
    public class DepthService : IDepth
    {
        private readonly ApplicationDbContext _context;

        public DepthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Depth> GetAll()
        {
            return _context.Depths;
        }

        public Depth GetById(int Id)
        {
            var depth = _context.Depths.Where(d => d.Id == Id).FirstOrDefault();

            return depth;
        }
    }
}
