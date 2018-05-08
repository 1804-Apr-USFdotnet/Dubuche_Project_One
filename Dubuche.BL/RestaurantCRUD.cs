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
