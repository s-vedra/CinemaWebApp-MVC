using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.Business.Mappers;
using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Implementation
{
    public class SnackService : ISnackService
    {
        private IRepository<Snack> _snackRepository;
        public SnackService(IRepository<Snack> snackRepository)
        {
            _snackRepository = snackRepository;
        }

        public void Add(SnackViewModel model)
        {
            Snack snack = new Snack()
            {
                Id = model.Id,
                Image = model.Image,
                Name = model.Name,
                Price = model.Price,
                SnackQuantity = model.SnackQuantity
            };
            _snackRepository.Add(snack);
        }

        public void Delete(SnackViewModel model)
        {
            _snackRepository.Delete(_snackRepository.GetEntity(model.Id));
        }

        public SnackViewModel GetSnackViewModel(int id)
        {
            return _snackRepository.GetEntity(id).ToViewModel();
        }

        public List<SnackViewModel> GetSnackViewModels()
        {
            return _snackRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public void Update(SnackViewModel model)
        {
            Snack snack = _snackRepository.GetEntity(model.Id);
            snack.Id = model.Id;
            snack.Image = model.Image;
            snack.Name = model.Name;
            snack.Price = model.Price;
            snack.SnackQuantity = model.SnackQuantity;
            _snackRepository.Update(snack);
        }
    }
}
