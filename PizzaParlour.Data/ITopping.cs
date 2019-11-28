using PizzaParlour.Data.Models;
using System.Collections.Generic;

namespace PizzaParlour.Data
{
    public interface ITopping
    {
        Topping GetById(int Id);
        IEnumerable<Topping> GetAll();
    }
}
