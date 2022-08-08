using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            return View(_movieService.GetMovies());
        }

        public IActionResult AddNewMovie(int id)
        {
            if (id != 0)
            {
                MovieViewModel movieViewModel = _movieService.GetMovie(id);
                return View(movieViewModel);
            }
            return View(new MovieViewModel());
        }
        [HttpPost]
        public IActionResult AddNewMovie(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.Id != 0)
                {
             
                    _movieService.Update(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    _movieService.AddMovie(model);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult DeleteMovie(int id)
        {
            _movieService.Delete(_movieService.GetMovie(id));
            return RedirectToAction("Index");
        }
        public IActionResult SearchMovie(string id)
        {
            if (string.IsNullOrEmpty(id) || !_movieService.GetMovies().Any(x => x.Title.ToLower().Contains(id.ToLower())))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(_movieService.GetMovies().Where(x => x.Title.ToLower().Contains(id.ToLower())).ToList());
            }
        }
    }
}
