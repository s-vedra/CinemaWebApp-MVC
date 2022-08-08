using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Abstraction
{
    public interface ICinemaHallService
    {
        List<CinemaHallViewModel> GetCinemaHalls();
        CinemaHallViewModel GetCinemaHall(int id);
        int AddCinemaHall(CinemaHallViewModel model);
        void Update(CinemaHallViewModel model);
    }
}
