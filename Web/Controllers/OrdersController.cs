using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
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
            //_order.SnackLines.Where(snackLine => snackLine.SnackId == snackLine.Id).ToList

            ViewBag.Extras = repo.GetExtras();
            ViewBag.PartialView = "./_Extras";
            ViewBag.Model = snackLine;

            return View("Details", _order);
        }

        [HttpPost]
        public IActionResult Extras(SnackLine snackLine)
        {
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

        [HttpPost]
        public IActionResult Details(OrderVM order)
        {
            _order = order;
            //repo.AddOrder(_order);

            return View("Index");
        }

    }
}
