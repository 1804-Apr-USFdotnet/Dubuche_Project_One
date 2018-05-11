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
    public class RestaurantSort
    {
        public static List<Restaurants> AlphaSorting(List<Restaurants> rests)
        {
            return rests.OrderBy(r => r.Name).ToList();
        }

        public static List<Restaurants> BetaSorting(List<Restaurants> rests)
        {
            return rests.OrderByDescending(r => r.Name).ToList();
        }

        public static void AlphaSortingPrint(List<Restaurants> rests)
        {
            List<Restaurants> newList = new List<Restaurants>();
            newList = AlphaSorting(rests);
            foreach (var r in newList)
            Console.WriteLine(r.Name);
        }
        
        public static void BetaSortingPrint(List<Restaurants> rests)
        {
            List<Restaurants> newList = new List<Restaurants>();
            newList = BetaSorting(rests);
            foreach (var r in newList)
             Console.WriteLine(r.Name);
        }

        //public static List<Restaurant> AvgRatingSort(List<Restaurant> rest)
        //{
        //    return rest.OrderByDescending(r => r.AvgRating).ToList();
        //}
    }
}
//Basic Requirements
// ## functionality
//* display top 3 restaurants by average rating
//* display all restaurants
//* should allow more than one method of sorting [done]
//* display details of a restaurant
//* display all the reviews of a restaurant
//* search restaurants(e.g.by partial name), and display all matching results
//* quit application