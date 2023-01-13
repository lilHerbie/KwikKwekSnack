using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SnackController : Controller
    {
        // GET: SnackController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SnackController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SnackController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SnackController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SnackController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SnackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SnackController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SnackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
