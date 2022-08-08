using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWebApp.Controllers
{
    public class SnackController : Controller
    {
        private readonly ISnackService _snackService;
        public SnackController(ISnackService snackService)
        {
            _snackService = snackService;
        }
        public IActionResult Index()
        {
            return View(_snackService.GetSnackViewModels());
        }
        public IActionResult AddNewSnack(int id)
        {
            if (id != 0)
            {
                SnackViewModel snackViewModel = _snackService.GetSnackViewModel(id);
                return View(snackViewModel);
            }
            return View(new SnackViewModel());
        }
        [HttpPost]
        public IActionResult AddNewSnack(SnackViewModel model)
        {
            if (model.Name != null && model.Image != null)
            {
                if (model.Id != 0)
                {
                    _snackService.Update(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    _snackService.Add(model);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult DeleteSnack(int id)
        {
            _snackService.Delete(_snackService.GetSnackViewModel(id));
            return RedirectToAction("Index");
        }
        public IActionResult SearchSnacks(string id)
        {
            if (string.IsNullOrEmpty(id) || !_snackService.GetSnackViewModels().Any(x => x.Name.ToLower().Contains(id.ToLower())))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(_snackService.GetSnackViewModels().Where(x => x.Name.ToLower().Contains(id.ToLower())).ToList());
            }
        }
    }
}
