using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dubuche.DAL;
using Dubuche.BL;
using NLog;

namespace Restaurants.MVC.Controllers
{
    public class RestaurantController : Controller
    {
        private Logger log;

        //Search
        public ActionResult Search(string Name)
        {
            var bl = new Dubuche.BL.RestaurantCRUD();
            
            List<Restaurant> newRestList = new List<Restaurant>();
            newRestList = bl.GetAllRestaurants();
            return View (RestaurantSearch.Lookup (newRestList, Name));
        }

        //public ActionResult Sort()
        //{

        //}

        // GET: Restaurant
        public ActionResult Index()
        {
            var bl = new Dubuche.BL.RestaurantCRUD();
            //var list = bl.GetAllRestaurants();

            return View(bl.GetAllRestaurants());

            //List<Restaurant> A
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            var bl = new Dubuche.BL.RestaurantCRUD();
            var x = bl.GetRestaurantById(id);
            return View(x);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            try
            {
                // TODO: Add insert logic here
                var bl = new Dubuche.BL.RestaurantCRUD();
                bl.CreateRestaurant(restaurant);
                
                return RedirectToAction("Index");
            }
            catch
            {
                log = LogManager.GetLogger("mistakes");
                return View();
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            var bl = new Dubuche.BL.RestaurantCRUD();
            var x = bl.GetRestaurantById(id);
            return View(x);
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Restaurant restaurant2)
        {
            try
            {
                // TODO: Add update logic here
                var bl = new Dubuche.BL.RestaurantCRUD();
                bl.UpdateRestaurant(restaurant2);
                return RedirectToAction("Index");
            }
            catch
            {
                log = LogManager.GetLogger("mistakes");
                return View();
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            var bl = new Dubuche.BL.RestaurantCRUD();
            //bl.DeleteRestaurantById(id);
            return View(bl.GetRestaurantById(id));
         
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Restaurant restaurant)
        {
            try
            {
                // TODO: Add delete logic here
                var bl = new Dubuche.BL.RestaurantCRUD();
                bl.DeleteRestaurantById(id);
                
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                log = LogManager.GetLogger("mistakes");
                log.Error($"[Restaurants Controller] [Details] Exception thrown: {e.Message}");
                return RedirectToAction("Index");
            }
        }
    }
}
