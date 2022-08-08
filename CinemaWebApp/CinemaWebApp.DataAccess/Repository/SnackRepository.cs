using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;

namespace CinemaWebApp.DataAccess.Repository
{
    public class SnackRepository : IRepository<Snack>
    {
        private readonly CinemaAppDbContext _dbContext;
        public SnackRepository(CinemaAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Snack entity)
        {
            _dbContext.Snacks.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Snack entity)
        {
            _dbContext.Snacks.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Snack> GetAll()
        {
            return _dbContext.Snacks.ToList();
        }

        public Snack GetEntity(int id)
        {
            return _dbContext.Snacks.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Snack entity)
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
