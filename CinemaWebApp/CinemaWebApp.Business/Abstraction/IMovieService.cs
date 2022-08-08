using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Abstraction
{
    public interface IMovieService
    {
        List<MovieViewModel> GetMovies();
        MovieViewModel GetMovie(int id);
        void AddMovie(MovieViewModel model);
        void Update(MovieViewModel model);
        void Delete(MovieViewModel model);
        List<MovieViewModel> RandomMovies();
    }
}
