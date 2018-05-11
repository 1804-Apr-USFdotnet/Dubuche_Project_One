using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dubuche.DAL;

namespace Dubuche.BL
{
    public class RestaurantCRUD
    {
        private DAL.RestaurantCRUD crud;

        public RestaurantCRUD()
        {
            crud = new DAL.RestaurantCRUD();
        }

        //Display All Restaurants
        public List<Restaurant> GetAllRestaurants()
        {
            return crud.GetAllRestaurants();
        }

        public static List<Dubuche.BL.Restaurants> Casting (List<Dubuche.DAL.Restaurant> restaurants)
        {
            List<Restaurants> res = new List<Restaurants>();

            foreach (var item in restaurants)
            {
                Restaurants rest = new Restaurants()
                {
                    Name = item.Name,
                    Address = item.Address,
                    Website = item.Website,
                    Phone = item.Phone,
                    Rating = item.Rating,
                    Id = item.Id
                };

                res.Add(rest);
            }

            return res;

        }

        //Create

        public void CreateRestaurant(Restaurant restaurant)
        {
            crud.CreateRestaurant(restaurant);
        }

        //Read

        public Restaurant GetRestaurantById(int id)
        {
            return crud.GetRestaurantById(id);
        }

        //Update

        public void UpdateRestaurant(Restaurant restaurant2)
        {
            crud.UpdateRestaurant(restaurant2);
        }

        //Delete

        public void DeleteRestaurantById(int id)
        {
            crud.DeleteRestaurantById(id);
        }
    }
}
