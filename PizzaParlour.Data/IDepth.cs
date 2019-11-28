using PizzaParlour.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaParlour.Data
{
    public interface IDepth
    {
        Depth GetById(int Id);
        IEnumerable<Depth> GetAll();
    }
}
