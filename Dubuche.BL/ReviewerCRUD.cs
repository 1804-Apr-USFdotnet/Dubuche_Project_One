using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dubuche.DAL;

namespace Dubuche.BL
{
    public class ReviewerCRUD
    {
        private DAL.ReviewerCRUD crud;

        public ReviewerCRUD()
        {
            crud = new DAL.ReviewerCRUD();
        }

        public List<Reviewer>AllReviewers()
        {
            return crud.AllReviewers();
        }
        
        public List<Reviewer>DisplayRestaurantReviews(int RestaurantId)
        {
            return crud.DisplayRestaurantReviews(RestaurantId);
        }

        public Reviewer DisplayRestaurantReviewersById(int id)
        {
            return crud.DisplayRestaurantReviewersById(id);
        }

        public void CreateReviewer(Reviewer reviewer)
        {
            crud.CreateReviewer(reviewer);
        }


        public void UpdateReviewers(Reviewer reviewer2)
        {
            crud.UpdateReviewers(reviewer2);
        }

        public void DeleteReviewerById(int id)
        {
            crud.DeleteReviewerById(id);
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
