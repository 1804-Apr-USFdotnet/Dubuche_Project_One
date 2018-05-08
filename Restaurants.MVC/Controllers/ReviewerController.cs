using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dubuche.DAL;
using Dubuche.BL;

namespace Restaurants.MVC.Controllers
{
    public class ReviewerController : Controller
    {
        // GET: Reviewer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reviewer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviewer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviewer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviewer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviewer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviewer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviewer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
