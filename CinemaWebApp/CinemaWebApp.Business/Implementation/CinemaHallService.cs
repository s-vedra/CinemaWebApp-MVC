using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.Business.Mappers;
using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Implementation
{
    public class CinemaHallService : ICinemaHallService
    {
        private readonly IRepository<CinemaHall> _cinemaHallRepository;
        public CinemaHallService(IRepository<CinemaHall> cinemaHallRepository)
        {
            _cinemaHallRepository = cinemaHallRepository;
        }

        public int AddCinemaHall(CinemaHallViewModel model)
        {
            CinemaHall cinemaHall = new CinemaHall()
            {
                MovieId = model.MovieId,
                SizeId = model.SizeId

            };
            _cinemaHallRepository.Add(cinemaHall);
            return cinemaHall.Id;
        }

        public CinemaHallViewModel GetCinemaHall(int id)
        {
            return _cinemaHallRepository.GetEntity(id).ToViewModel();
        }

        public List<CinemaHallViewModel> GetCinemaHalls()
        {
            return _cinemaHallRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public void Update(CinemaHallViewModel model)
        {
            CinemaHall cinemaHall = _cinemaHallRepository.GetEntity(model.Id);
            cinemaHall.Id = model.Id;
            cinemaHall.MovieId = model.MovieId;
            cinemaHall.SizeId = model.SizeId;
            _cinemaHallRepository.Update(cinemaHall);
        }
    }
}
