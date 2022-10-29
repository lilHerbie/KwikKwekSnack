using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KwikKwekSnack_ClassLibary;

namespace KwikKwekSnack_Web.Controllers
{
    public class OrdersController : Controller
    {
        // GET: OrdersController
        public ActionResult Index()
        {
            Order order = new Order();
            using (var ctx = new DatabaseContext())
            {
                ctx.Orders.Add(order);
                ctx.SaveChanges();
                ViewData["Snacks"] = ctx.Snacks.ToList();
            }
            System.Diagnostics.Debug.WriteLine(order.Id);
            return View(order);
        }

        // GET: OrdersController/Edit/5
        public ActionResult AddSnack(int level, int id)
        {

            System.Diagnostics.Debug.WriteLine(id);
            try
            {
                SnackLine snackLine = new SnackLine();
                Order order;
                using (var ctx = new DatabaseContext())
                {
                    order = ctx.Orders.Find(id);
                    ViewData["Snack"] = ctx.Snacks.Find(level);
                    ViewData["Extras"] = ctx.Extras.ToList();
                    ViewData["SnackLine"] = snackLine;
                }
                return View(order);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
