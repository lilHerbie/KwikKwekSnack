using KwikKwekSnack_ClassLibary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KwikKwekSnack_Web.Controllers
{
    public class ExtraController : Controller
    {

        DatabaseRepo _repo;

        public ExtraController()
        {
            _repo = new DatabaseRepo();
        }

        // GET: ExtraController
        public ActionResult Index()
        {
            return View(_repo.GetAllExtras());
        }

        // GET: ExtraController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_repo.GetExtra(id));
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
        public ActionResult Create(Extra extra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.AddExtra(extra);
                    return RedirectToAction(nameof(Index));

                }
                return View(extra);
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
                _repo.GetExtra(id);
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
        public ActionResult Edit(Extra extra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.UpdateExtra(extra);
                    return RedirectToAction(nameof(Index));
                }
                return View(extra);
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
                return View(_repo.GetExtra(id));
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: ExtraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Extra extra)
        {
            try
            {

                _repo.RemoveExtra(extra);
                return RedirectToAction(nameof(Index)); return View(extra);
            }
            catch
            {
                return View();
            }
        }
    }
}
