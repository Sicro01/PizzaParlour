using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaParlour.Data.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public virtual Size Size { get; set; }
        public virtual Depth Depth { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }

        public IEnumerable<PizzaTopping> PizzaToppings { get; set; }
    }
}
