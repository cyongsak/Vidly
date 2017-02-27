using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movie = new Movie() {Name = "Titanic"};
            return View(movie);
        }

        // GET: Movie/Random
        // will show movies and customer
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek Movie"};
            var customers = new List<Customer>()
            {
                new Customer() {Name = "John Watson" },
                new Customer() {Name = "Sherlock Holm"}
            };
            var var = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(var);
        }
    }
}