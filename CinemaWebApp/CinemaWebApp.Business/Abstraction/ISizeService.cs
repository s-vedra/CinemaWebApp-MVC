using CinemaWebApp.ViewModels;

namespace CinemaWebApp.Business.Abstraction
{
    public interface ISizeService
    {
        List<SizeViewModel> GetSizes();
    }
}
