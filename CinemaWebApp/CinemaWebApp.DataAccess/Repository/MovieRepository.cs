using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;

namespace CinemaWebApp.DataAccess.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly CinemaAppDbContext _dbContext;
        public MovieRepository(CinemaAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Movie entity)
        {
            _dbContext.Movies.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Movie entity)
        {
            _dbContext.Movies.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _dbContext.Movies.ToList();
        }

        public Movie GetEntity(int id)
        {
            return _dbContext.Movies.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Movie entity)
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
