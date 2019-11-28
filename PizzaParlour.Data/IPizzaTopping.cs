using PizzaParlour.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaParlour.Data
{
    public interface IPizzaTopping
    {
        IEnumerable<PizzaTopping> GetAllByPizzaId(int PizzaId);

        Task Create(PizzaTopping pizzaTopping);
        Task Delete(PizzaTopping pizzaTopping);
        Task DeleteAll(IEnumerable<PizzaTopping> pizzaToppings);
    }
}
