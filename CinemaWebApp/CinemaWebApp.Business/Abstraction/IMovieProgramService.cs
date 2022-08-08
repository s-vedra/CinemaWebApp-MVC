using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Abstraction
{
    public interface IMovieProgramService
    {
        List<MovieProgramViewModel> GetMoviePrograms();
        MovieProgramViewModel GetMovieProgram(int id);
        void AddMovieProgram(MovieProgramViewModel model);
        void Update(MovieProgramViewModel model);
        void Delete(MovieProgramViewModel model);
    }
}
