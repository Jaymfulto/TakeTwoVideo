using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TakeTwoVideo.Models;
using TakeTwoVideo.ViewModels;
using System.Data.Entity;

namespace TakeTwoVideo.Controllers
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

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList(); 
            return View(movies);
        }
        public ActionResult Details(int? id)
        {
            Movie movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            //Movie movie = _context.Movies.Include(m => m.Genre.Id == id);
            return View(movie);
        }
        public ActionResult Random()
        { 
            List<Movie> movies = new List<Movie>()
            {
                new Movie {Name = "Shrek!" },
                new Movie {Name = "Wall-e" }

            };
            return View(movies);
        }
        public ActionResult New()
        {
            var movieViewModel = new MovieFormViewModel
            {
                Genres = _context.Genres.ToList(),
                Movie = new Movie()

            };
           
            return View("MovieForm", movieViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                var movieFormViewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()

                };
                return View("MovieForm", movieFormViewModel);
            }

            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;

            }
            _context.SaveChanges();

            return RedirectToAction("Index","Movies");

        }
        public ActionResult Edit(int? id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            var editMovieViewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()

            };

            return View("MovieForm", editMovieViewModel);
        }


   
       
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}