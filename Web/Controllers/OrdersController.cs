using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly Repository repo;
        public Order _order;

        public OrdersController()
        {
            _order = new Order();
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
            snackLine.Id = 2;
            snackLine.SnackName = snack.Name;
            _order.SnackLines.Add(snackLine);

            ViewBag.Extras = repo.GetExtras();
            ViewBag.PartialView = "./_Extras";
            ViewBag.Model = snackLine;

            return View("Details", _order);
        }

        [HttpPost]
        public IActionResult Extras(SnackLine snackLine)
        {
            _order.SnackLines.Add(snackLine);
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
        public IActionResult Details(Order order)
        {
            _order = order;
            repo.AddOrder(_order);

            return View("Index");
        }

    }
}
