using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp
{
    public interface IReviewRepository
    {
        //Getall method returns a list of reviews
        IEnumerable<Review> GetAll();

        //findbyid method returns a review
        Review GetById(int id);
    }
}
