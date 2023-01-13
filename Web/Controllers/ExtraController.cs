using ClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ExtraController : Controller
    {
        Repository _repo = new Repository();

        // GET: SnackController
        public ActionResult Index()
        {
            return View(_repo.GetExtras());
        }

        // GET: SnackController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_repo.GetExtraById(id));
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
        public ActionResult Create(Extra extra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.AddSnack(extra);
                    return RedirectToAction(nameof(Index));
                }

                return View(extra);
            }
            catch
            {
                return View();
            }
        }


        // GET: SnackController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetExtraById(id));
        }

        // POST: SnackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Extra extra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.UpdateSnack(extra);
                    return RedirectToAction(nameof(Index));
                }

                return View(extra);
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: SnackController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View(_repo.GetExtraById(id));
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }


        // POST: SnackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Extra extra)
        {

            try
            {
                _repo.RemoveDrink(extra);
                return RedirectToAction(nameof(Index)
                    )
                ; return View(extra);
            }
            catch
            {
                return View();
            }

        }
    }
}
