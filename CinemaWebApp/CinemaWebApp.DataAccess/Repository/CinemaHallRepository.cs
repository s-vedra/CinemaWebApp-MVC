using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApp.DataAccess.Repository
{
    public class CinemaHallRepository : IRepository<CinemaHall>
    {
        private readonly CinemaAppDbContext _dbContext;
        public CinemaHallRepository(CinemaAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(CinemaHall entity)
        {
            _dbContext.CinemaHalls.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(CinemaHall entity)
        {
            _dbContext.CinemaHalls.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<CinemaHall> GetAll()
        {
            return _dbContext.CinemaHalls.Include(x => x.Movie).Include(x => x.Size).ToList();
        }

        public CinemaHall GetEntity(int id)
        {
            return _dbContext.CinemaHalls.Include(x => x.Movie).Include(x => x.Size).SingleOrDefault(x => x.Id == id);
        }

        public void Update(CinemaHall entity)
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
