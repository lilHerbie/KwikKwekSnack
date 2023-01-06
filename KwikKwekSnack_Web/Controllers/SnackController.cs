using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KwikKwekSnack_ClassLibary;

namespace KwikKwekSnack_Web.Controllers
{
    public class SnackController : Controller
    {

        DatabaseRepo _repo;

        public SnackController()
        {
            _repo = new DatabaseRepo();
        }

        // GET: SnackController
        public ActionResult Index()
        {
            using (var ctx = new DatabaseContext())
            {
                return View(_repo.GetAllSnacks());
            }
        }

        // GET: SnackController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_repo.GetSnack(id));
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
            try
            {
                _repo.GetSnack(id);
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
        public ActionResult Edit(Snack snack)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.UpdateSnack(snack);
                    return RedirectToAction(nameof(Index));
                }
                return View(snack);
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
                return View(_repo.GetSnack(id));
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
