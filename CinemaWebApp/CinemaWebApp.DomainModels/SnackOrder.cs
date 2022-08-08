namespace CinemaWebApp.DomainModels
{
    public class SnackOrder
    {
        public int Id { get; set; }
        public ICollection<Snack> Snacks { get; set; }
        public SnackOrder()
        {

        }
        public SnackOrder(ICollection<Snack> snacks)
        {
            Snacks = snacks;
        }
    }
}
