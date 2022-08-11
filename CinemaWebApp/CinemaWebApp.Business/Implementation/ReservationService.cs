﻿using CinemaWebApp.Business.Abstraction;
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
            reservation.SnackOrders = SnackOrder(model.SnackOrders.Where(x => x.Select).ToList());
            reservation.SnackPrice = GetSnackPrice(reservation.SnackOrders.ToList());
            reservation.LastName = model.LastName;
            reservation.TicketQuantity = model.TicketQuantity;
            reservation.TicketPrice = _movieProgramRepository.GetEntity(model.MovieProgramId).Price * reservation.TicketQuantity;
            reservation.FullPrice = reservation.SnackPrice + reservation.TicketPrice;
            _reservationRepository.Add(reservation);
        }
        private List<SnackOrder> SnackOrder(List<SnackOrderViewModel> snacks)
        {
            List<SnackOrder> snackOrders = new List<SnackOrder>();
          
            foreach (var item in snacks)
            {
                SnackOrder snackOrder = new SnackOrder();
                Snack snack = _snackRepository.GetEntity(item.Snack.Id);
                snackOrder.SnackQuantity = item.SnackQuantity;
                snackOrder.Price = snackOrder.SnackQuantity * snack.Price;
                snackOrder.Snack = snack;
                snackOrders.Add(snackOrder);
                _snackOrderRepository.Add(snackOrder);
            }
           
            return snackOrders;
        }
        private decimal GetSnackPrice(List<SnackOrder> snackOrders)
        {
            decimal price = 0;
            foreach (var item in snackOrders)
            {
                price += item.Snack.Price * item.SnackQuantity;
            }
            return price;
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
