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
            return View(order);
        }     

        // GET: OrdersController/Edit/5
        public ActionResult AddSnack(int level, int id)
        {
            try
            {
                Order order;
                SnackLine snackLine = new SnackLine();
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

        public ActionResult AddExtraToSnackline(SnackLine snackline, Extra extra)
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }


        //add snackline to order
        public ActionResult AddToOrder(Order model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Attach(model);
                        ctx.Orders.Update(model);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));

                }
                return View(model);
            }
            catch
            {
                return View();
            }
        }
    }
}
