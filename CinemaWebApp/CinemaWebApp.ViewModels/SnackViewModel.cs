namespace CinemaWebApp.ViewModels
{
    public class SnackViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public bool Select { get; set; }
        public string? Image { get; set; }
        public int SnackQuantity { get; set; }
    }
}
