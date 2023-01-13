using ClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SnackController : Controller
    {
        Repository _repo = new Repository();

        // GET: SnackController
        public ActionResult Index()
        {
            return View(_repo.GetSnacks());
        }

        // GET: SnackController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_repo.GetSnackById(id));
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
        public ActionResult Create(Snack snack)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.AddSnack(snack);
                    return RedirectToAction(nameof(Index));
                }

                return View(snack);
            }
            catch
            {
                return View();
            }
        }


        // GET: SnackController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetSnackById(id));
        }

        // POST: SnackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Snack snack)
        {
            try
            {
                _repo.GetSnackById(id);
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: SnackController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View(_repo.GetSnackById(id));
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }


        // POST: SnackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Snack snack)
        {

            try
            {
                _repo.RemoveSnack(snack);
                return RedirectToAction(nameof(Index)
                    )
                ; return View(snack);
            }
            catch
            {
                return View();
            }

        }
    }
}
