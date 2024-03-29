﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KwikKwekSnack_ClassLibary;

namespace KwikKwekSnack_Web.Controllers
{
    public class OrdersController : Controller
    {
        // GET: OrdersController
        public ActionResult Index()
        {
            Order order = new Order();
            using (var ctx = new DatabaseContext())
            {
                ctx.Orders.Add(order);
                ctx.SaveChanges();
                ViewData["Snacks"] = ctx.Snacks.ToList();
            }
            return View(order);
        }

        // GET: OrdersController/Edit/5
        //public ActionResult AddSnack(int level, int id)
        //{     
        //    try
        //    {
        //        SnackLine snackLine = new SnackLine();
        //        Order order;
        //        using (var ctx = new DatabaseContext())
        //        {
        //            order = ctx.Orders.Find(id);
        //            order.Snacks.Add(snackLine);
        //            //snackLine.Snack = ctx.Snacks.Find(level);
        //            ViewData["Snack"] = ctx.Snacks.Find(level);
        //            ViewData["Extras"] = ctx.Extras.ToList();
        //            ViewData["SnackLine"] = snackLine;
        //            ctx.Orders.Attach(order);
        //            ctx.Orders.Update(order);
        //            ctx.SaveChanges();

        //        }
        //        return View(order);
        //    }
        //    catch (Exception)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //}

        //public void addExtraToSnackLine(Extra extra, SnackLine snackLine)
        //{
        //    snackLine.Extras.Add(extra);
        //}
    }
}
