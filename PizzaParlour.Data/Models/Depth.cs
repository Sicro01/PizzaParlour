using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaParlour.Data.Models
{
    public class Depth
    {
        public int Id { get; set; }

        [DisplayName("Depths")]
        public string Description { get; set; }

        [DisplayName("Depth Prices")]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
    }
}
