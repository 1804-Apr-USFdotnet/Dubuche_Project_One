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
            var bl = new Dubuche.BL.ReviewerCRUD();
            return View();
        }

        // GET: Reviewer/Details/5
        public ActionResult Details(int id)
        {
            var bl = new Dubuche.BL.ReviewerCRUD();
            var x = bl.DisplayRestaurantReviews(id);
            return View(x);
        }

        // GET: Reviewer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviewer/Create
        [HttpPost]
        public ActionResult Create(Reviewer reviewer)
        {
            try
            {
                // TODO: Add insert logic here
                var bl = new Dubuche.BL.ReviewerCRUD();
                bl.CreateReviewer(reviewer);

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
            var bl = new Dubuche.BL.ReviewerCRUD();
            var x = bl.DisplayRestaurantReviewersById(id);
            return View(x);
        }

        // POST: Reviewer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Reviewer reviewer2)
        {
            try
            {
                // TODO: Add update logic here
                var bl = new Dubuche.BL.ReviewerCRUD();
                bl.UpdateReviewers(reviewer2);
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
            var bl = new Dubuche.BL.ReviewerCRUD();
            return View(bl.DisplayRestaurantReviewersById(id));
        }

        // POST: Reviewer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var bl = new Dubuche.BL.ReviewerCRUD();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
