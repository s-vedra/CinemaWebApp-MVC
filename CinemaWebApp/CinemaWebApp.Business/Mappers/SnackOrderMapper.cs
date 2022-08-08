using CinemaWebApp.DomainModels;
using CinemaWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApp.Business.Mappers
{
    public static class SnackOrderMapper
    {
        public static SnackOrderViewModel ToViewModel(this SnackOrder snackOrder)
        {
            return new SnackOrderViewModel()
            {   
                Id = snackOrder.Id,
                Snacks = snackOrder.Snacks.Select(x => x.ToViewModel()).ToList()
            };
        }
    }
}
