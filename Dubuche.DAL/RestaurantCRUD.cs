using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubuche.DAL
{
    public class RestaurantCRUD
    {
        private RestaurantsEntities _db;

        public RestaurantCRUD()
        {
            _db = new RestaurantsEntities();

        }

        //Display All Restaurants

        public List<Restaurant> GetAllRestaurants()
        {
            var list = _db.Restaurants.ToList();
            return list;
        }

        //Create

        public void CreateRestaurant(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();

        }

        //Read
        public Restaurant GetRestaurantById(int id)
        {
            var restaurant = _db.Restaurants.Find(id);
            return restaurant;
        }

        //Update

        public void UpdateRestaurant(Restaurant restaurant2)
        {
            Restaurant restaurant1 = _db.Restaurants.Find(restaurant2.Id);
            restaurant1.Phone = restaurant2.Phone;
            restaurant1.Name = restaurant2.Name;
            restaurant1.Website = restaurant2.Website;
            _db.SaveChanges();

        }

        //Delete
        public void DeleteRestaurantById(int id)
        {
            Restaurant restaurant = _db.Restaurants.Find(id);
            _db.Restaurants.Remove(restaurant);
            _db.SaveChanges();
        }
    }
}
//Basic Requirements
// ## functionality
//* display top 3 restaurants by average rating
//* display all restaurants [done]
//* should allow more than one method of sorting [done]
//* display details of a restaurant [done]
//* display all the reviews of a restaurant
//* search restaurants(e.g.by partial name), and display all matching results
//* quit application