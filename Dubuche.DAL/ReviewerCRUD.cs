using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dubuche.DAL;


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

        public List<Reviewer> DisplayRestaurantReviews(int RestaurantId)
        {
            var list = _db.Restaurants.Find(RestaurantId);
            list.Reviewers.ToList();
            return list.Reviewers.ToList();
            
        }

        //Create Reviewer
        public void CreateReviewer(Reviewer reviewer)
        {
            _db.Reviewers.Add(reviewer);
            _db.SaveChanges();

        }
        //Read
        public Reviewer DisplayRestaurantReviewersById(int id)
        {
            var reviewer = _db.Reviewers.Find(id);
            return reviewer;
        }

        //Update
        public void UpdateReviewers(Reviewer reviewer2)
        {
            Reviewer reviewer1 = _db.Reviewers.Find(reviewer2.Id);
            reviewer1.Name = reviewer2.Name;
            reviewer1.Comment = reviewer2.Comment;
            reviewer1.Rating = reviewer2.Rating;
            _db.SaveChanges();

        }

        //Delete
        public void DeleteReviewerById(int id)
        {
            Reviewer reviewer = _db.Reviewers.Find(id);
            _db.Reviewers.Remove(reviewer);
            _db.SaveChanges();
        }
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
