using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            return View(movie);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" }); // (name of action, controller, anonymous object) ---> redirects to URL containing /?page=1&sortBy=name
        }

        public ActionResult Edit(int id) // id is same as in Controller
        {
            return Content("id=" + id);
            //http://localhost:52148/movies/edit/1
            //http://localhost:52148/movies/edit/?id=1
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy) // ? makes int nullable, not required for string type
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("movies/released/{year:regex(\\d{4}:range(1800, 2100)}/{month:regex(^\\d{1,2}$):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}