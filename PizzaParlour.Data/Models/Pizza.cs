using System.Collections.Generic;

namespace PizzaParlour.Data.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string Depth { get; set; }

        public virtual IEnumerable<Topping> Toppings { get; set; }
        public virtual Depth PizzaDepth {get; set;}
    }
}
