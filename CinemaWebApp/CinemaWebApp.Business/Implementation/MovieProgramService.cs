using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.Business.Mappers;
using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Implementation
{
    public class MovieProgramService : IMovieProgramService
    {
        private readonly IRepository<MovieProgram> _movieProgramRepository;

        public MovieProgramService(IRepository<MovieProgram> movieProgramRepository)
        {
            _movieProgramRepository = movieProgramRepository;
        }

        public void AddMovieProgram(MovieProgramViewModel model)
        {
            MovieProgram movieProgram = new MovieProgram()
            {
                CinemaHallId = model.CinemaHallId,
                Date = model.Date,
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                Price = model.Price,
            };
            _movieProgramRepository.Add(movieProgram);
        }

        public void Delete(MovieProgramViewModel model)
        {
            _movieProgramRepository.Delete(_movieProgramRepository.GetEntity(model.Id));
        }

        public MovieProgramViewModel GetMovieProgram(int id)
        {
            return _movieProgramRepository.GetEntity(id).ToViewModel();
        }

        public List<MovieProgramViewModel> GetMoviePrograms()
        {
            return _movieProgramRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public void Update(MovieProgramViewModel model)
        {
            MovieProgram movieProgram = _movieProgramRepository.GetEntity(model.Id);
            movieProgram.Id = model.Id;
            movieProgram.CinemaHallId = model.CinemaHallId;
            movieProgram.Date = model.Date;
            movieProgram.EndTime = model.EndTime;
            movieProgram.Price = model.Price;
            movieProgram.StartTime = model.StartTime;
            _movieProgramRepository.Update(movieProgram);
        }
    }
}
