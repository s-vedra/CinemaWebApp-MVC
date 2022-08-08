using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApp.DataAccess.Repository
{
    public class ReservationRepository : IRepository<Reservation>
    {
        private readonly CinemaAppDbContext _dbContext;
        public ReservationRepository(CinemaAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Reservation entity)
        {
            _dbContext.Reservations.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Reservation entity)
        {
            _dbContext.Reservations.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Reservation> GetAll()
        {
            return _dbContext.Reservations.Include(x => x.SnackOrder).ThenInclude(x => x.Snacks)
                .Include(x => x.MovieProgram)
                .ThenInclude(x => x.CinemaHall)
                .ThenInclude(x => x.Movie)
                .Include(x => x.MovieProgram)
                .ThenInclude(x => x.CinemaHall)
                .ThenInclude(x => x.Size).ToList();
        }

        public Reservation GetEntity(int id)
        {
            return _dbContext.Reservations
                .Include(x => x.SnackOrder).ThenInclude(x => x.Snacks)
                .Include(x => x.MovieProgram)
                .ThenInclude(x => x.CinemaHall)
                .ThenInclude(x => x.Movie)
                .Include(x => x.MovieProgram)
                .ThenInclude(x => x.CinemaHall)
                .ThenInclude(x => x.Size)
                .SingleOrDefault(x => x.Id == id);
        }

        public void Update(Reservation entity)
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
