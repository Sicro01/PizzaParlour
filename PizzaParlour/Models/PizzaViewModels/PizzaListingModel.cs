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

        [Required(ErrorMessage = "You must select a Pizza Size.")]
        public int SelectedSizeId { get; set; }
        public IEnumerable<Depth> Depths{ get; set; }
        [Required(ErrorMessage = "You must select a Pizza Depth.")]
        public int SelectedDepthId { get; set; }

        public IEnumerable<Topping> Toppings{ get; set; }
        public List<int> IsToppingChecked { get; set; }
        public OrderedPizza CustomerPizza { get; set; }
    }
}
