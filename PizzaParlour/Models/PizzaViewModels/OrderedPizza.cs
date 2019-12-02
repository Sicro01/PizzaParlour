using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaParlour.Models.PizzaViewModels
{
    public class OrderedPizza
    {
        public int Id { get; set; }
        public int SizeId { get; set; }
        public string SizeDescription { get; set; }
        public decimal SizePrice { get; set; }
        public int DepthId { get; set; }
        public string DepthDescription { get; set; }
        public decimal DepthPrice { get; set; }

        public decimal OrderedPizzaPrice { get; set; }
        public IEnumerable<OrderedPizzaTopping> OrderedPizzaToppings { get; set; }
    }
}
