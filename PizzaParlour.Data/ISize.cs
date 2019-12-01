using PizzaParlour.Data.Models;
using System.Collections.Generic;

namespace PizzaParlour.Data
{
    public interface ISize
    {
        Size GetById(int Id);
        List<Size> GetAll();
    }
}
