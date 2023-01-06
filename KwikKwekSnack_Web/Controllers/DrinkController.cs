using KwikKwekSnack_ClassLibary;
using Microsoft.AspNetCore.Mvc;

namespace KwikKwekSnack_Web.Controllers
{
    public class DrinkController : Controller
    {

        DatabaseRepo _repo;

        public DrinkController()
        {
            _repo = new DatabaseRepo();
        }

        // GET: DrinkController
        public ActionResult Index()
        {
            return View(_repo.GetAllDrinks());
           
        }

        // GET: DrinkController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_repo.GetDrink(id));
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
        public ActionResult Create(Drink drink)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.AddDrink(drink);
                    return RedirectToAction(nameof(Index));

                }
                return View(drink);
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
                _repo.GetDrink(id);
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
        public ActionResult Edit(Drink drink)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.UpdateDrink(drink);
                    return RedirectToAction(nameof(Index));

                }
                return View(drink);
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
                return View(_repo.GetDrink(id));
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: DrinkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Drink drink)
        {
            try
            {

                _repo.RemoveDrink(drink);
                return RedirectToAction(nameof(Index)); return View(drink);
            }
            catch
            {
                return View();
            }
        }
    }
}
