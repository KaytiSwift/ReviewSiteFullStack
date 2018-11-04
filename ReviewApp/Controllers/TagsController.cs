using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Controllers
{
    public class TagsController : Controller
    {
        //field of type IReviewRepository
        private ITagRepository tagRepo;

        //constructor which takes in an IReviewRepository and sets it to tagRepo field
        public TagsController(ITagRepository tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        //method that calls the GetAll method and saves it(all the tags) as a model, passes it into the view and returns the view
        public ViewResult Index()
        {
            var model = tagRepo.GetAll();
            return View(model);
        }

        //method that calls the findbyid method and saves it(specific tag) as a model, passes it to the view and returns the view
        public ViewResult Details(int id)
        {
            var model = tagRepo.GetById(id);
            return View(model);
        }
    }
}

