using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp
{
    public interface ICategoryRepository
    {
        //Getall method returns a list of reviews
        IEnumerable<Category> GetAll();

        //findbyid method returns a review
        Category GetById(int id);
    }
}
