using Microsoft.AspNetCore.Mvc;
using PizzaParlour.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaParlour.Models.PizzaViewModels
{
    public class PizzaListingModel
    {
        public Pizza Pizza { get; set; }
        
        public IEnumerable<Size> Sizes { get; set; }
        public int SelectedSizeId { get; set; }
        public IEnumerable<Depth> Depths{ get; set; }
        public int SelectedDepthId { get; set; }
        public IEnumerable<Topping> Toppings{ get; set; }
        public List<int> IsToppingChecked { get; set; }

        //[DisplayFormat(DataFormatString = "{0:C0}")]
        [DataType(DataType.Currency)]
        public decimal PizzaPrice { get; set; }
        
    }
}
