using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaParlour.Data.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
    }
}
