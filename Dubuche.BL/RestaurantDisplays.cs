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
    public class RestaurantDisplays
    {
        public List<Restaurants> rests = new List<Restaurants>();
        public List<Restaurants> rests2 = new List<Restaurants>();
        public List<Reviewers> rates = new List<Reviewers>();

    }

    
}
    
//Restaurants db = new Restaurants();


//Basic Requirements
// ## functionality
//* display top 3 restaurants by average rating
//* display all restaurants
//* should allow more than one method of sorting
//* display details of a restaurant
//* display all the reviews of a restaurant
//* search restaurants(e.g.by partial name), and display all matching results
//* quit application