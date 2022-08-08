using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Mappers
{
    public static class SizeMapper
    {
        public static SizeViewModel ToViewModel(this Size size)
        {
            return new SizeViewModel
            {
                Id = size.Id,
                Description = size.Description,
                Seats = size.Seats
            };
        }
    }
}
