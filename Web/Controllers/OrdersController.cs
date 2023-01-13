using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly Repository repo;
        private Order order;

        public OrdersController()
        {      
            repo = new();
        }

        public IActionResult Index()
        {
            order = new();
            return RedirectToAction("Details", order);
        }

        public IActionResult Details(Order order)
        {
            //possibly pas partialview

            ViewBag.Snacks = repo.GetSnacks();
            ViewBag.PartialView = "./_Snacks";



            return View(order);
        }

        [HttpGet]

        public IActionResult Extras(int snackId, Order order)
        {
            Snack snack = repo.GetSnackById(snackId);
            SnackLine snackLine = new SnackLine();
            snackLine.Snack = snack;
            snackLine.SnackId = snackId;
            order.SnackLines.Add(snackLine);

            ViewBag.Extras = repo.GetExtras();
            ViewBag.PartialView = "./_Extras";
            ViewBag.Model = snackLine;

            return View("Details", order);
        }

        //[HttpPost]
        //public IActionResult Extras(ViewModel vm)
        //{
           
        //    foreach(int Extraid in vm.ExtraIds)
        //    {
        //        ExtraLine extraLine = new();
        //        extraLine.ExtraId = Extraid;
        //        vm.CurrentSnackLine.ExtraLines.Add(extraLine);
        //    }

        //    vm.PartialView = "./Snacks";

        //    return View("Index", vm);
        //}

        //public IActionResult AddExtra(int extraId, ViewModel vm)
        //{
        //    vm.ExtraIds.Add(extraId);
        //    vm.PartialView = "./Extras";
        //    return View("Index", vm);
        //}

        [HttpPost]
        public IActionResult SubmitOrder()
        {
            repo.AddOrder(order);

            return View("Index");
        }

    }
}
