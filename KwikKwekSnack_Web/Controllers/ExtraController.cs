using KwikKwekSnack_ClassLibary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KwikKwekSnack_Web.Controllers
{
    public class ExtraController : Controller
    {
        // GET: ExtraController
        public ActionResult Index()
        {
            using (var ctx = new DatabaseContext())
            {
                return View(ctx.Extras.ToList());
            }
        }

        // GET: ExtraController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    return View(ctx.Extras.Find(id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: ExtraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExtraController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Extra model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Extras.Add(model);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction("Index");

                }
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: ExtraController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    ctx.Extras.Find(id);
                }
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: ExtraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Extra model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Attach(model);
                        ctx.Extras.Update(model);
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

        // GET: ExtraController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    return View(ctx.Extras.Find(id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: ExtraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Extra model)
        {
            try
            {

                using (var ctx = new DatabaseContext())
                {
                    ctx.Extras.Attach(model);
                    ctx.Extras.Remove(model);
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
