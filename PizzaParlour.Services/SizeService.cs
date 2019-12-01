using System;
using System.Collections.Generic;
using System.Linq;
using PizzaParlour.Data;
using PizzaParlour.Data.Models;

namespace PizzaParlour.Service
{
    public class SizeService : ISize
    {
        private readonly ApplicationDbContext _context;

        public SizeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Size> GetAll()
        {
            List<Size> sizes;
            sizes = _context.Sizes.ToList();
            return sizes;
        }

        public Size GetById(int Id)
        {
            var size = _context.Sizes.Where(s => s.Id == Id).FirstOrDefault();

            return size;
        }
    }
}
