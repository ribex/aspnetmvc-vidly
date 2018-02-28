using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Joan Rivers", Id = 1 },
                new Customer { Name = "Snoopy", Id = 2 },
                new Customer { Name = "Glenn Close", Id = 3 },
                new Customer { Name = "Meryl Streep", Id = 4 }

            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        //[Route("/details/{id}")]
        //public ActionResult Details(int id) // id is same as in Controller
        //{



        //    return Content( + id);
        //    //http://localhost:52148/movies/edit/1
        //    //http://localhost:52148/movies/edit/?id=1
        //}
    }
}