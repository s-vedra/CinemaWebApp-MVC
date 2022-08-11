using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApp.DataAccess.Repository
{
    public class SnackOrderRepository : IRepository<SnackOrder>
    {
        private readonly CinemaAppDbContext _dbContext;
        public SnackOrderRepository(CinemaAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(SnackOrder entity)
        {
            _dbContext.SnackOrders.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(SnackOrder entity)
        {
            _dbContext.SnackOrders.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<SnackOrder> GetAll()
        {
            return _dbContext.SnackOrders.Include(x => x.Snack).ToList();
        }

        public SnackOrder GetEntity(int id)
        {
            return _dbContext.SnackOrders.Include(x => x.Snack).SingleOrDefault(x => x.Id == id);
        }

        public void Update(SnackOrder entity)
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
