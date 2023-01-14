using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Models;

namespace Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly Repository repo;
        public OrderVM _order;

        public OrdersController(OrderVM orderVM)
        {
            _order = orderVM;
            repo = new();
        }

        public IActionResult Index()
        {

            return RedirectToAction("Details");
        }

        [HttpGet]
        public IActionResult Details()
        {
            //possibly pas partialview

            ViewBag.Snacks = repo.GetSnacks();
            ViewBag.PartialView = "./_Snacks";



            return View(_order);
        }

        [HttpGet]
        public IActionResult Extras(int snackId)
        {
            Snack snack = repo.GetSnackById(snackId);
            SnackLine snackLine = new SnackLine();
            snackLine.Snack = snack;
            snackLine.SnackId = snackId;
            snackLine.SnackName = snack.Name;
            _order.SnackLines.Add(snackLine);

            ViewBag.Extras = repo.GetExtras();
            ViewBag.PartialView = "./_Extras";
            ViewBag.Model = snackLine;

            return View("Details", _order);
        }

        [HttpPost]
        public IActionResult AddExtra(int extraid, SnackLine snackLine)
        {
            Extra extra = repo.GetExtraById(extraid);
            ExtraLine extraLine = new ExtraLine();
            extraLine.Extra = extra;
            extraLine.ExtraId = extraid;
            extraLine.ExtraName = extra.Name;
            extraLine.SnackLineId = snackLine.Id;
            snackLine.ExtraLines.Add(extraLine);

            Snack snack = repo.GetSnackById(snackLine.SnackId);
            snackLine.Snack = snack;
            snackLine.SnackName = snack.Name;
            _order.SnackLines.LastOrDefault().ExtraLines.Add(extraLine);

            ViewBag.Extras = repo.GetExtras();
            ViewBag.PartialView = "./_Extras";
            ViewBag.Model = snackLine;

            return View("Details", _order);
        }

        [HttpPost]
        public IActionResult Extras(SnackLine snackLine, bool remove)
        {
            if (remove)
            {
                _order.SnackLines.Remove(_order.SnackLines.LastOrDefault());
            }
            else
            {
                for (int i = 0; i < snackLine.Amount - 1; i++)
                {
                    _order.SnackLines.Add(_order.SnackLines.LastOrDefault());
                }
            }

            ViewBag.Snacks = repo.GetSnacks();
            ViewBag.PartialView = "./_Snacks";
            return View("Details", _order);
        }

        [HttpGet]
        public IActionResult Drinks()
        {
            ViewBag.Drinks = repo.GetDrinks();
            ViewBag.PartialView = "./_Drinks";

            return View("Details", _order);
        }

        [HttpGet]
        public IActionResult DrinkOptions(int drinkId)
        {
            Drink drink = repo.GetDrinkById(drinkId);
            DrinkLine drinkLine = new();

            drinkLine.Drink = drink;
            drinkLine.DrinkId = drinkId;
            drinkLine.DrinkName = drink.Name;
            _order.DrinkLines.Add(drinkLine);

            ViewBag.PartialView = "./_DrinkOptions";
            ViewBag.Model = drinkLine;

            List<Size> sizes = new List<Size> { Size.S, Size.M, Size.L, Size.XL };
            SelectList sizesSelectList = new SelectList(sizes, nameof(Size));
            ViewBag.Sizes = sizesSelectList;

            return View("Details", _order);
        }

        [HttpPost]
        public IActionResult DrinkOptions(DrinkLine drinkLine, bool remove)
        {
            if (remove)
            {
                _order.DrinkLines.Remove(_order.DrinkLines.LastOrDefault());
            }
            else
            {
                for (int i = 0; i < drinkLine.Amount - 1; i++)
                {
                    _order.DrinkLines.Add(_order.DrinkLines.LastOrDefault());
                }
            }

            _order.DrinkLines.LastOrDefault().HasStraw = drinkLine.HasStraw;
            _order.DrinkLines.LastOrDefault().HasIce = drinkLine.HasIce;
            _order.DrinkLines.LastOrDefault().Size = drinkLine.Size;

            ViewBag.Model = drinkLine;
            ViewBag.PartialView = "./_Drinks";
            ViewBag.Drinks = repo.GetDrinks();

            return View("Details", _order);
        }

        [HttpGet]
        public IActionResult Overview()
        {
            return View(_order);
        }

        public IActionResult Submit()
        {
            Order order = new Order();
            order.SnackLines = _order.SnackLines;
            order.DrinkLines = _order.DrinkLines;
            order.TotalCost = _order.TotalCost;
            order.Status = Status.queued;

            //foreach(SnackLine snackLine in order.SnackLines)
            //{
            //    foreach(ExtraLine extraLine in snackLine.ExtraLines)
            //    {
            //        ExtraLine _extraLine = new ExtraLine();
            //        _extraLine.ExtraName = _extraLine.ExtraName;
                    
            //        repo.AddExtraLine(extraLine);
            //    }
            //    repo.AddSnackLine(snackLine);
            //}
            //foreach(DrinkLine drinkLine in order.DrinkLines)
            //{
            //    repo.AddDrinkLine(drinkLine);
            //}
            repo.AddOrder(order);

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public IActionResult Details(OrderVM order)
        //{
        //    _order = order;
        //    //repo.AddOrder(_order);

        //    return View("Index");
        //}
    }
}
