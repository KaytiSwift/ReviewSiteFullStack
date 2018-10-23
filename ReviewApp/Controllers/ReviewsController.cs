using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Controllers
{
    public class ReviewsController : Controller
    {
        //field of type IReviewRepository
        private IReviewRepository reviewRepo;

        //constructor which takes in an IReviewRepository and sets it to reviewRepo field
        public ReviewsController(IReviewRepository reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        //method that calls the GetAll method and saves it(all the reviews) as a model, passes it into the view and returns the view
        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }

        //method that calls the findbyid method and saves it(specific review) as a model, passes it to the view and returns the view
        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }
    }

    
}
