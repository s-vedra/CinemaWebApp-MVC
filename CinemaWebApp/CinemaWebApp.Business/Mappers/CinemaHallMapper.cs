using CinemaWebApp.DataAccess;
using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApp.Business.Mappers
{
    public static class CinemaHallMapper
    {
        public static CinemaHallViewModel ToViewModel(this CinemaHall cinemaHall)
        {
            return new CinemaHallViewModel
            {
                Id = cinemaHall.Id,
                MovieId =  cinemaHall.MovieId,
                Movie = cinemaHall.Movie.ToViewModel(),
                Size = cinemaHall.Size.ToViewModel(),
                SizeId = cinemaHall.SizeId
            };
        }
    }
}
