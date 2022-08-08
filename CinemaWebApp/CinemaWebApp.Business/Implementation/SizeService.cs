using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.Business.Mappers;
using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Implementation
{
    public class SizeService : ISizeService
    {
        private readonly IRepository<Size> _sizeRepository;
        public SizeService(IRepository<Size> sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }
        public List<SizeViewModel> GetSizes()
        {
            return _sizeRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }
    }
}
