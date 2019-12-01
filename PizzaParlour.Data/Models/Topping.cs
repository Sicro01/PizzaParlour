using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaParlour.Data.Models
{
    public class Topping
    {
        public int Id { get; set; }
        [DisplayName("Toppings")]
        public string Description { get; set; }

        [DisplayName("Topping Prices")]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
    }
}
