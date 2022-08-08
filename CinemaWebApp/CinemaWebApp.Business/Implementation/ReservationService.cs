using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.Business.Mappers;
using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;


namespace CinemaWebApp.Business.Implementation
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservationRepository;
        private readonly IRepository<Snack> _snackRepository;
        private readonly IRepository<MovieProgram> _movieProgramRepository;
        private readonly IRepository<SnackOrder> _snackOrderRepository;
        public ReservationService(IRepository<Reservation> reservationRepository, IRepository<Snack> snackRepository, IRepository<MovieProgram> movieProgramRepository, IRepository<SnackOrder> snackOrderRepository)
        {
            _reservationRepository = reservationRepository;
            _snackRepository = snackRepository;
            _movieProgramRepository = movieProgramRepository;
            _snackOrderRepository = snackOrderRepository;
        }

        public void Add(ReservationViewModel model)
        {
            Reservation reservation = new Reservation();
            reservation.Name = model.Name;
            reservation.MovieProgramId = model.MovieProgramId;
            reservation.SnackOrderId = SnackOrder(model.Snacks.Where(x => x.Select).ToList());
            reservation.SnackPrice = GetSnackPrice(reservation.SnackOrderId);
            reservation.LastName = model.LastName;
            reservation.TicketQuantity = model.TicketQuantity;
            reservation.TicketPrice = _movieProgramRepository.GetEntity(model.MovieProgramId).Price * reservation.TicketQuantity;
            reservation.FullPrice = reservation.SnackPrice + reservation.TicketPrice;
            _reservationRepository.Add(reservation);
        }
        private int SnackOrder(List<SnackViewModel> snacks)
        {
            SnackOrder snackOrder = new SnackOrder();
            foreach (var item in snacks)
            {
                Snack snack = _snackRepository.GetEntity(item.Id);
                snack.SnackQuantity = item.SnackQuantity;
                snackOrder.Snacks = new List<Snack>();
                snackOrder.Snacks.Add(snack);
            }
            _snackOrderRepository.Add(snackOrder);
            return snackOrder.Id;
        }
        private decimal GetSnackPrice(int SnackOrderId)
        {
            SnackOrder snackOrder = _snackOrderRepository.GetEntity(SnackOrderId);
            return snackOrder.Snacks.Select(x => x.Price).Sum() * snackOrder.Snacks.Select(x => x.SnackQuantity).Sum();
        }
        public void Delete(ReservationViewModel model)
        {
            _reservationRepository.Delete(_reservationRepository.GetEntity(model.Id));
        }

        public ReservationViewModel GetReservationViewModel(int id)
        {
            return _reservationRepository.GetEntity(id).ToViewModel();
        }

        public List<ReservationViewModel> GetReservationViewModels()
        {
            return _reservationRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }
    }
}
