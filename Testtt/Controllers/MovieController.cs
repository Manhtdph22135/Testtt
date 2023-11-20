using Microsoft.AspNetCore.Mvc;
using Testtt.Models;
using Testtt.Services;

namespace Testtt.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieServices _movieServices;

        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var aa = _movieServices.GetAllMovies();
            var movies = aa.Select(mv => new MoviViewModel(mv));
            return View(movies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Movies mv)
        {
            var result = _movieServices.addMovie(mv);
            if (result)
            {
                return RedirectToAction("Index");
            }

            return BadRequest();
        }
    }
}
