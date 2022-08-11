using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CinemaWebApp.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly ISnackService _snackService;
     
        public ReservationController(IReservationService reservationService, ISnackService snackService)
        {
            _reservationService = reservationService;
            _snackService = snackService;
        }
        public IActionResult Index()
        {
            return View(_reservationService.GetReservationViewModels());
        }
        public IActionResult GetMovieProgram(int id)
        {
            return RedirectToAction("MakeAReservation",new ReservationViewModel() { MovieProgramId = id });
        }
        public IActionResult MakeAReservation(ReservationViewModel model)
        {
            List<SnackViewModel> snacks = _snackService.GetSnackViewModels();
            ViewBag.Snacks = snacks;
            model.SnackOrders = null;
            return View(model);
        }
        [HttpPost]
        public IActionResult SaveReservation(ReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                _reservationService.Add(model);
                return RedirectToAction("Index");
            }
            return RedirectToAction("MakeAReservation", model);
        }
        public IActionResult Details(int id)
        {
            return View(_reservationService.GetReservationViewModel(id));
        }
        public IActionResult DeleteReservation(int id)
        {
            _reservationService.Delete(_reservationService.GetReservationViewModel(id));
            return RedirectToAction("Index");
        }
        public IActionResult SearchReservation(string id)
        {
            if (int.TryParse(id, out int resId))
            {
                    if (_reservationService.GetReservationViewModels().Any(x => x.Id == resId))
                    {
                        return View(_reservationService.GetReservationViewModel(resId));
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }
                  
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
