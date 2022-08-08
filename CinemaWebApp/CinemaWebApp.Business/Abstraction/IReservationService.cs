using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Abstraction
{
    public interface IReservationService
    {
        ReservationViewModel GetReservationViewModel(int id);
        List<ReservationViewModel> GetReservationViewModels();
        void Add(ReservationViewModel model);
        void Delete(ReservationViewModel model);
    }
}
