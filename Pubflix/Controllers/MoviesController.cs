using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pubflix.Models;
using Pubflix.ViewModels;

namespace Pubflix.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies / Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek 2" };
            var customers = new List<Customer>
            {
                new Customer { Name = "John 1" },
                new Customer { Name = "Jim 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            return View(viewModel);
        }




     /*Other Routes / Configurations that aren't set up yet:
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //movies/edit?id=1 or /movies/edit/1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        */
    }
    
}