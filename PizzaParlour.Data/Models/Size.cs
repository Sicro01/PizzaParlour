using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaParlour.Data.Models
{
    public class Size
    {
        public int Id { get; set; }

        [DisplayName("Sizes")]
        [BindProperty]
        public string Description { get; set; }

        [DisplayName("Size Prices")]
        [Column(TypeName = "decimal(5,2)")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
    }
}
