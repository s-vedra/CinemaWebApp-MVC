using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApp.Business.Mappers
{
    public static class SnacksMapper
    {
        public static SnackViewModel ToViewModel(this Snack snack)
        {
            return new SnackViewModel
            {
                Id = snack.Id,
                Name = snack.Name,
                Price = snack.Price,
                Image = snack.Image,
              
            };
        }
    }
}
