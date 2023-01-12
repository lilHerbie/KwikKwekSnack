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
            order = new();
            repo = new();
        }

        public IActionResult Index()
        {
            ViewModel vm = new();
            vm.PartialView = "./Snacks";

            ViewBag.Snacks = repo.GetSnacks();

            return View(vm);
        }

        [HttpGet]
        public IActionResult Extras(int snackId, ViewModel vm)
        {
            Snack snack = repo.GetSnackById(snackId);
            vm.CurrentSnackLine = new();
            vm.CurrentSnackLine.SnackId = vm.SnackId;

            vm.PartialView = "./Extras";
            vm.SnackId = snackId;
            vm.SnackName = snack.Name;
            vm.SnackUrl = snack.ImageUrl;

            ViewBag.Extras = repo.GetExtras();

            return View("Index", vm);
        }

        [HttpPost]
        public IActionResult Extras(ViewModel vm)
        {
          

           
            foreach(int Extraid in vm.ExtraIds)
            {
                ExtraLine extraLine = new();
                extraLine.ExtraId = Extraid;
                vm.CurrentSnackLine.ExtraLines.Add(extraLine);
            }

            vm.SnackLines.Add(vm.CurrentSnackLine);
            vm.CurrentSnackLine = null;
            vm.PartialView = "./Snacks";

            return View("Index", vm);
        }

        public IActionResult AddExtra(int extraId, ViewModel vm)
        {
            vm.ExtraIds.Add(extraId);
            vm.PartialView = "./Extras";
            return View("Index", vm);
        }

        [HttpPost]
        public IActionResult SubmitOrder()
        {
            repo.AddOrder(order);

            return View("Index");
        }

    }
}
