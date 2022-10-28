using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KwikKwekSnack_ClassLibary;

namespace KwikKwekSnack_Web.Controllers
{
    public class SnackController : Controller
    {
        // GET: SnackController
        public ActionResult Index()
        {
            using (var ctx = new DatabaseContext())
            {
                return View(ctx.Snacks.ToList());
            }
                
        }

        // GET: SnackController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    return View(ctx.Snacks.Find(id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        // GET: SnackController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SnackController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Snack model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Snacks.Add(model);
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

        // GET: SnackController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    ctx.Snacks.Find(id);
                }
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: SnackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Snack model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Attach(model);
                        ctx.Snacks.Update(model);
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

        // GET: SnackController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                using (var ctx = new DatabaseContext())
                {
                    return View(ctx.Snacks.Find(id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: SnackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Snack model)
        {
            try
            {
             
                    using (var ctx = new DatabaseContext())
                    {
                        ctx.Snacks.Attach(model);
                        ctx.Snacks.Remove(model);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));return View(model);
            }
            catch
            {
                return View();
            }
        }
    }
}
