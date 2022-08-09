using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.Business.Mappers;
using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieViewModel model)
        {
            Movie movie = new Movie()
            {
                Title = model.Title,
                Genre = model.Genre,
                Duration = model.Duration,
                YearReleased = model.YearReleased,
                Image = model.Image,
                Description = model.Description == null ? "" : model.Description,
            };
            _movieRepository.Add(movie);
        }

        public void Delete(MovieViewModel model)
        {
            _movieRepository.Delete(_movieRepository.GetEntity(model.Id));
        }

        public MovieViewModel GetMovie(int id)
        {
            return _movieRepository.GetEntity(id).ToViewModel();
        }

        public List<MovieViewModel> GetMovies()
        {
            return _movieRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public List<MovieViewModel> RandomMovies()
        {
            Random random = new Random();
            List<MovieViewModel> movieModels = GetMovies();
            List<MovieViewModel> moviesModelsToSend = new List<MovieViewModel>();
            for (int i = 0; i < 4; i++)
            {
                int rnd = random.Next(1, movieModels.Count);
                MovieViewModel movie = movieModels[rnd];

                if (moviesModelsToSend.Contains(movie))
                {
                    moviesModelsToSend.Remove(movie);
                }
                else
                {
                    moviesModelsToSend.Add(movie);
                }
            }
            return moviesModelsToSend;
        }

        public void Update(MovieViewModel model)
        {
            Movie movie = _movieRepository.GetEntity(model.Id);
            movie.Id = model.Id;
            movie.Duration = model.Duration;
            movie.Description = model.Description;
            movie.Genre = model.Genre;
            movie.Image = model.Image;
            movie.Title = model.Title;
            movie.YearReleased = model.YearReleased;
            _movieRepository.Update(movie);
        }
    }
}
