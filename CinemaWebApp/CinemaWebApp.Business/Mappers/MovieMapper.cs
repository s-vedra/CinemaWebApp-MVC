using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApp.Business.Mappers
{
    public static class MovieMapper
    {
        public static MovieViewModel ToViewModel(this Movie movie)
        {
            return new MovieViewModel
            {
                Id = movie.Id,
                Description = movie.Description,
                Duration = movie.Duration,
                Genre = movie.Genre,
                Title = movie.Title,
                YearReleased = movie.YearReleased,
                Image = movie.Image
            };
        }
    }
}
