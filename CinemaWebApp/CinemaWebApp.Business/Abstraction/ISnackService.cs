using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Abstraction
{
    public interface ISnackService
    {
        List<SnackViewModel> GetSnackViewModels();
        SnackViewModel GetSnackViewModel(int id);
        void Update(SnackViewModel model);
        void Add(SnackViewModel model);
        void Delete(SnackViewModel model);
    }
}
