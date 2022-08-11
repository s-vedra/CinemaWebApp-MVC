using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApp.Business.Mappers
{
    public static class ReservationMapper
    {
        public static ReservationViewModel ToViewModel(this Reservation reservation)
        {
            return new ReservationViewModel 
            {
                Id = reservation.Id,
                Name = reservation.Name,
                LastName = reservation.LastName,
                FullPrice = reservation.FullPrice,
                MovieProgramId = reservation.MovieProgramId,
                TicketQuantity = reservation.TicketQuantity,
                SnackPrice = reservation.SnackPrice,
                MovieProgram = reservation.MovieProgram.ToViewModel(),
                TicketPrice = reservation.TicketPrice,
                SnackOrders = reservation.SnackOrders.Select(x => x.ToViewModel()).ToList()
            };
        }
    }
}
