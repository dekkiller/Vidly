using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};

            ViewData["Movie"] = movie;
            var customers = new List<Customer>
            {
                new Customer {Name = "Kobe Bryant"},
                new Customer {Name = "Lebron James"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

//            return View();
//            return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

////        [Route("Customers")]
////        public ActionResult Customers(int id)
////        {
////            var movie = new List<Movie>
////            {
////                new Movie {Name = "Shrek"},
////                new Movie {Name = "Boku no hero"}
////            };
////
////            var customers = new List<Customer>
////            {
////                new Customer {Name = "Kobe Bryant"},
////                new Customer {Name = "Lebron James"}
////            };
////        }
//
//        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
//        public ActionResult ByReleaseDate(int year, int month)
//        {
//            return Content(year + "/" + month);
//        }
//
//        public ActionResult Edit(int Id)
//        {
//            return Content("Id = " + Id);
//        }

        //default action for movies controller


        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.ID == Id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            else
            {
                return View(movie);
            }
        }


//        public IEnumerable<Movie> GetMovies()
//        {
//            return new List<Movie>
//            {
//                new Movie {Name = "Space Jam 1", ID = 1},
//                new Movie {Name = "Space Jam 2", ID = 2}
//            };
//
//        }
    }
}