using ClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class DrinkController : Controller
    {
        Repository _repo = new Repository();

        // GET: SnackController
        public ActionResult Index()
        {
            return View(_repo.GetDrinks());
        }

        // GET: SnackController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_repo.GetDrinkById(id));
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


        // GET: SnackController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetDrinkById(id));
        }

        // POST: SnackController/Edit/5
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
                return View(_repo.GetDrinkById(id));
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }


        // POST: SnackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Drink drink)
        {

            try
            {
                _repo.RemoveDrink(drink);
                return RedirectToAction(nameof(Index)
                    )
                ; return View(drink);
            }
            catch
            {
                return View();
            }

        }
    }
}
