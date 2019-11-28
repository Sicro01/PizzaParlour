using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaParlour.Data.Models
{
    public class PizzaTopping
    {
        public int Id { get; set; }
        public virtual Pizza Pizza { get; set; }
        public virtual Topping Topping { get; set; }
    }
}
