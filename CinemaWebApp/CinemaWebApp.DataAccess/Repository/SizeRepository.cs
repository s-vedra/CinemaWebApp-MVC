using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;

namespace CinemaWebApp.DataAccess.Repository
{
    public class SizeRepository : IRepository<Size>
    {
        private readonly CinemaAppDbContext _dbContext;
        public SizeRepository(CinemaAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Size entity)
        {
            _dbContext.Sizes.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Size entity)
        {
            _dbContext.Sizes.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Size> GetAll()
        {
            return _dbContext.Sizes.ToList();
        }

        public Size GetEntity(int id)
        {
            return _dbContext.Sizes.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Size entity)
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
