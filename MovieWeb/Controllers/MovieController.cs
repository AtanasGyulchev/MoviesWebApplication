using Microsoft.AspNetCore.Mvc;
using MovieWeb.Data;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _db;

        public MovieController (AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Movie> objMovieList = _db.Movies.ToList();


            return View(objMovieList);
        }
    }
}
