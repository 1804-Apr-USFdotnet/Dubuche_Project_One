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
    public static class RestaurantSearch
    {
       
        public static List<Restaurant> Lookup(List<Restaurant> restaurants, string sub)
        {
            List<Restaurant> newRestList = new List<Restaurant>();
            foreach (var one in restaurants)
            {
                if (one.Name.ToLower().Contains(sub.ToLower()))
                    newRestList.Add(one);
            }
            return newRestList;
        }
    }
}
//Basic Requirements
// ## functionality
//* display top 3 restaurants by average rating
//* display all restaurants
//* should allow more than one method of sorting
//* display details of a restaurant
//* display all the reviews of a restaurant
//* search restaurants(e.g.by partial name), and display all matching results [semi-complete]
//* quit application