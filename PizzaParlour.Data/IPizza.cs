using PizzaParlour.Data.Models;
using System.Collections.Generic;

namespace PizzaParlour.Data
{
    public interface IPizza
    {
        Pizza GetById(int Id);
        IEnumerable<Pizza> GatAll();
    }
}
