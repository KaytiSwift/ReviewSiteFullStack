using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReviewApp.Controllers
{
    public class CategoryController : Controller
    {
        //field of type IReviewRepository
        private ICategoryRepository categoryRepo;

        //constructor which takes in an IReviewRepository and sets it to reviewRepo field
        public CategoryController(ICategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        //method that calls the GetAll method and saves it(all the reviews) as a model, passes it into the view and returns the view
        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }

        //method that calls the findbyid method and saves it(specific review) as a model, passes it to the view and returns the view
        public ViewResult Details(int id)
        {
            var model = categoryRepo.GetById(id);
            return View(model);
        }
    }
}