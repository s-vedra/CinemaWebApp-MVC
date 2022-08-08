using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApp.DataAccess.Repository
{
    public class MovieProgramRepository : IRepository<MovieProgram>
    {
        private readonly CinemaAppDbContext _dbContext;
        public MovieProgramRepository(CinemaAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(MovieProgram entity)
        {
            _dbContext.MoviePrograms.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(MovieProgram entity)
        {
            _dbContext.MoviePrograms.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<MovieProgram> GetAll()
        {
            return _dbContext.MoviePrograms
                .Include(x => x.CinemaHall)
                .ThenInclude(x => x.Movie)
                .Include(x => x.CinemaHall)
                .ThenInclude(x => x.Size).ToList();
        }

        public MovieProgram GetEntity(int id)
        {
            return _dbContext.MoviePrograms
                .Include(x => x.CinemaHall)
                .ThenInclude(x => x.Movie)
                .Include(x => x.CinemaHall)
                .ThenInclude(x => x.Size)
                .SingleOrDefault(x => x.Id == id);
        }

        public void Update(MovieProgram entity)
        {
            var item = GetEntity(entity.Id);
            if (item != null)
            {
                _dbContext.Entry(item).CurrentValues.SetValues(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}
