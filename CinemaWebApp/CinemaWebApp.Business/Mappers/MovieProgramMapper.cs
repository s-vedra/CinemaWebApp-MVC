using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApp.Business.Mappers
{
    public static class MovieProgramMapper
    {
        public static MovieProgramViewModel ToViewModel(this MovieProgram movieProgram)
        {
            return new MovieProgramViewModel
            {
                Id = movieProgram.Id,
                CinemaHallId = movieProgram.CinemaHallId,
                CinemaHall = movieProgram.CinemaHall.ToViewModel(),
                Date = movieProgram.Date,
                StartTime = movieProgram.StartTime,
                EndTime = movieProgram.EndTime,
                Price = movieProgram.Price
            };
        }
    }
}
