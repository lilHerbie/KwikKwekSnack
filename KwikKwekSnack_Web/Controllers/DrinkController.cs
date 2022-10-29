using KwikKwekSnack_ClassLibary;
using Microsoft.AspNetCore.Mvc;

namespace KwikKwekSnack_Web.Controllers
{
    public class DrinkController : Controller
    {
        // GET: DrinkController
        public ActionResult Index()
        {
            using (var ctx = new DatabaseContext())
            {
                return View(ctx.Drinks.ToList());
            }
           
        }

        // GET: DrinkController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    return View(ctx.Drinks.Find(id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: DrinkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrinkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Drink model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Drinks.Add(model);
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

        // GET: DrinkController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    ctx.Drinks.Find(id);
                }
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: DrinkController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Drink model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Attach(model);
                        ctx.Drinks.Update(model);
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

        // GET: DrinkController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                using var ctx = new DatabaseContext();
                return View(ctx.Drinks.Find(id));
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: DrinkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Drink model)
        {
            try
            {

                using (var ctx = new DatabaseContext())
                {
                    ctx.Drinks.Attach(model);
                    ctx.Drinks.Remove(model);
                    ctx.SaveChanges();
                }
                return RedirectToAction(nameof(Index)); return View(model);
            }
            catch
            {
                return View();
            }
        }
    }
}
