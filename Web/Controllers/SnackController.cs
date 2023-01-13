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
            return View(_repo.GetSnackById(id));
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
            _repo.AddSnack(snack);
            return RedirectToAction("Index", "Snacks");
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
            _repo.UpdateSnack(snack);
            return RedirectToAction("Index", "Snacks");
        }

        // GET: SnackController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repo.GetSnackById(id));
        }

        // POST: SnackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Snack snack)
        {
            _repo.RemoveSnack(snack);
            return RedirectToAction("Index", "Snacks");
        }
    }
}
