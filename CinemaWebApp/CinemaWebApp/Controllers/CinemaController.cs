using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CinemaWebApp.Controllers
{
    public class CinemaController : Controller
    {
        private readonly IMovieProgramService _movieProgramService;
        private readonly ICinemaHallService _cinemaHallService;
        private readonly ISizeService _sizeService;
        private readonly IMovieService _movieService;
        private readonly IReservationService _reservationService;
        public CinemaController(IMovieProgramService movieProgramService, ICinemaHallService cinemaHallService, ISizeService sizeService, IMovieService movieService, IReservationService reservationService)
        {
            _movieProgramService = movieProgramService;
            _cinemaHallService = cinemaHallService;
            _sizeService = sizeService;
            _movieService = movieService;
            _reservationService = reservationService;
        }
        public IActionResult Index()
        {
            ViewBag.DateTimes = _movieProgramService.GetMoviePrograms().Select(x => x.Date.ToShortDateString()).Distinct().ToList();
            ViewBag.Reservations = _reservationService.GetReservationViewModels();
            return View(_movieProgramService.GetMoviePrograms());
        }
        public IActionResult Details(int id)
        {
            ViewBag.Movies = _movieService.GetMovies();
            ViewBag.MoviePrograms = _movieProgramService.GetMoviePrograms();
            return View(_movieProgramService.GetMovieProgram(id));
        }
        public IActionResult AddCinemaHallModel(int id)
        {
            ViewBag.SizeHalls = _sizeService.GetSizes().Select(x => new SelectListItem(x.Description, x.Id.ToString())).ToList();
            ViewBag.Movies = _movieService.GetMovies().Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
            if (id != 0)
            {
                CinemaHallViewModel cinemaHallViewModel = _cinemaHallService.GetCinemaHall(id);
                return View(cinemaHallViewModel);
            }
            return View(new CinemaHallViewModel());
        }
        [HttpPost]
        public IActionResult AddCinemaHallModel(CinemaHallViewModel model)
        {
            ViewBag.SizeHalls = _sizeService.GetSizes().Select(x => new SelectListItem(x.Description, x.Id.ToString())).ToList();
            ViewBag.Movies = _movieService.GetMovies().Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
            if (ModelState.IsValid)
            {
                if (model.Id != 0)
                {
                    _cinemaHallService.Update(model);
                    return RedirectToAction("Index");
                }
                int id = _cinemaHallService.AddCinemaHall(model);
                return RedirectToAction("SaveCinemaHallModel",new MovieProgramViewModel() { CinemaHallId = id});
            }
            return View(model);
        }

        public IActionResult SaveCinemaHallModel(MovieProgramViewModel model)
        {
            return View(model);
        }

        public IActionResult EditProgram(int id)
        {
            MovieProgramViewModel movieProgramViewModel = _movieProgramService.GetMovieProgram(id);
            movieProgramViewModel.ChangeCinemaHall = true;
            return RedirectToAction("SaveCinemaHallModel", movieProgramViewModel);
        }

        [HttpPost]
        public IActionResult AddNewProgram(MovieProgramViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id != 0)
                {

                    _movieProgramService.Update(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    _movieProgramService.AddMovieProgram(model);
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("SaveCinemaHallModel", model);
        }
     
       public IActionResult DeleteProgram(int id)
       {
            _movieProgramService.Delete(_movieProgramService.GetMovieProgram(id));
            return RedirectToAction("Index");
       }
        public IActionResult SearchMovieProgram(string id)
        {
            if (string.IsNullOrEmpty(id) || !_movieProgramService.GetMoviePrograms().Any(x => x.CinemaHall.Movie.Title.ToLower().Contains(id.ToLower())))
            {
                return RedirectToAction("Index");
            }
            else
            {

                ViewBag.DateTimes = _movieProgramService.GetMoviePrograms().Where(x => x.CinemaHall.Movie.Title.ToLower().Contains(id.ToLower())).Select(x => x.Date.ToShortDateString()).Distinct().ToList();
                ViewBag.Reservations = _reservationService.GetReservationViewModels();
                return View(_movieProgramService.GetMoviePrograms().Where(x => x.CinemaHall.Movie.Title.ToLower().Contains(id.ToLower())).ToList());
            }
        }
    }
}
