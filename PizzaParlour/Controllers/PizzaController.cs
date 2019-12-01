using Microsoft.AspNetCore.Mvc;
using PizzaParlour.Data;
using PizzaParlour.Models.PizzaViewModels;
using PizzaParlour.Service;
using System.Linq;

namespace PizzaParlour.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ISize _sizeService;
        private readonly IDepth _depthService;
        private readonly ITopping _toppingService;
        private readonly IPizza _pizzaService;
        private readonly IPizzaTopping _pizzaToppingService;

        public PizzaController(ISize sizeService, IDepth depthService, ITopping toppingService, IPizza pizzaService, IPizzaTopping pizzaToppingService)
        {
            _sizeService = sizeService;
            _depthService = depthService;
            _toppingService = toppingService;
            _pizzaService = pizzaService;
            _pizzaToppingService = pizzaToppingService;
        }

        public IActionResult Index()
        {
            var sizes = _sizeService.GetAll();
            var depths = _depthService.GetAll();
            var toppings = _toppingService.GetAll();

            var model = new PizzaListingModel
            {
                Sizes = sizes,
                Depths = depths,
                Toppings = toppings
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Order(PizzaListingModel model)
        {

            decimal pizzaPrice = 0;

            foreach (var pizzaItem in model.Sizes)
            {
                if (pizzaItem.Description.Contains("10"))
                {
                    pizzaPrice += pizzaItem.Price;
                }
                else if (pizzaItem.Description.Contains("13"))
                {
                    pizzaPrice += pizzaItem.Price;
                }
                else
                {
                    pizzaPrice += pizzaItem.Price;
                }
            }

            foreach (var pizzaItem in model.Depths)
            {
                if (pizzaItem.Description.Contains("Deep"))
                {
                    pizzaPrice += pizzaItem.Price;
                }
                else
                {
                    pizzaPrice += pizzaItem.Price;
                }
            }

            return RedirectToAction("Index");
        }
    }
}
    