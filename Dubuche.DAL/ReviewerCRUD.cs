using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubuche.DAL
{
    public class ReviewerCRUD
    {
        private RestaurantsEntities _db;

        public ReviewerCRUD()
        {
            _db = new RestaurantsEntities();
        }

        //Display A Restaurant's Review


    }
}
//Basic Requirements
// ## functionality
//* display top 3 restaurants by average rating
//* display all restaurants [done]
//* should allow more than one method of sorting [
//* display details of a restaurant [done]
//* display all the reviews of a restaurant
//* search restaurants(e.g.by partial name), and display all matching results
