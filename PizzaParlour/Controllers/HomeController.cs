using Microsoft.AspNetCore.Mvc;
using PizzaParlour.Data;
using PizzaParlour.Models.PizzaViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaParlour.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISize _sizeService;
        private readonly IDepth _depthService;
        private readonly ITopping _toppingService;
        private readonly IPizza _pizzaService;
        private readonly IPizzaTopping _pizzaToppingService;

        public HomeController(ISize sizeService, IDepth depthService, ITopping toppingService, IPizza pizzaService, IPizzaTopping pizzaToppingService)
        {
            _sizeService = sizeService;
            _depthService = depthService;
            _toppingService = toppingService;
            _pizzaService = pizzaService;
            _pizzaToppingService = pizzaToppingService;
        }

        public IActionResult Index()
        {
            // Display pizza options to Customer
            var model = BuildModel(new OrderedPizza());
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(PizzaListingModel model)
        {
            // If there are errors e.g. no size/depth selected then re-display the Index with a new model
            if (model.SelectedSizeId != 0 && model.SelectedDepthId != 0)
            {
                // Build the pizza object based on Customer selections and display the prices
                var orderedPizza = BuildNewPizza(model.SelectedSizeId, model.SelectedDepthId, model.IsToppingChecked);
                var newmodel = BuildModel(orderedPizza);
                return View(newmodel);
            }
            else
            {
                model = BuildModel(new OrderedPizza());
                return View(model);
            }
        }

        private PizzaListingModel BuildModel(OrderedPizza orderedPizza)
        {
            var sizes = _sizeService.GetAll();
            var depths = _depthService.GetAll();
            var toppings = _toppingService.GetAll();
            var model = new PizzaListingModel
            {
                Sizes = sizes,
                Depths = depths,
                Toppings = toppings,
                CustomerPizza = orderedPizza
            };

            return model;
        }
        private OrderedPizza BuildNewPizza(int sizeId, int depthId, List<int> toppingIds)
        {

            // Retrieve the selected pizza size and depth
            var orderedSize = _sizeService.GetById(sizeId);
            var orderedDepth = _depthService.GetById(depthId);

            // Build promos
            string promo1 = "Pepperoni" + "Green Peppers" + "Anchovies";
            string promo2 = "Pepperoni" + "Onions" + "Red Peppers";

            // Create a new pizza for the cutomer and build aout the size and depth details which have been chosen
            OrderedPizza orderedPizza = new OrderedPizza()
            {
                SizeId = orderedSize.Id,
                SizeDescription = orderedSize.Description,
                SizePrice = orderedSize.Price,
                DepthId = orderedDepth.Id,
                DepthDescription = orderedDepth.Description,
                DepthPrice = orderedDepth.Price,
                OrderedPizzaPrice = orderedSize.Price + orderedDepth.Price
            };

            // Process each topping - add to a list, add list to the pizza entity and add topping prices to total pizza price
            List<OrderedPizzaTopping> orderedToppings = new List<OrderedPizzaTopping>();
            string toppingDescs = "";

            if (toppingIds?.Any() ?? false)
            {
                foreach (var item in toppingIds)
                {
                    var _t = _toppingService.GetById(item);
                    toppingDescs += _t.Description;
                    orderedToppings.Add(new OrderedPizzaTopping
                    {
                        Id = _t.Id,
                        Description = _t.Description,
                        Price = _t.Price
                    });
                    orderedPizza.OrderedPizzaPrice += _t.Price;
                };
                // Test and apply promos
                if (toppingDescs == promo1 || toppingDescs == promo2)
                {
                    orderedPizza.OrderedPizzaPrice = orderedPizza.OrderedPizzaPrice - 2;
                };
            };

            orderedPizza.OrderedPizzaToppings = orderedToppings;

            return (orderedPizza);
        }
    }
}

