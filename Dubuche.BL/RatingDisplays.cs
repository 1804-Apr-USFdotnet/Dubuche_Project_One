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
    public class RatingDisplays
    {
        public List<Reviewers> AvgRatings(List<Reviewers> rates)
        {
            return rates.OrderByDescending(r => r.Rating).ToList();
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
//* search restaurants(e.g.by partial name), and display all matching results
//* quit application