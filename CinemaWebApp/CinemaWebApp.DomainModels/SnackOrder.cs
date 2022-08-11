namespace CinemaWebApp.DomainModels
{
    public class SnackOrder
    {
        public int Id { get; set; }
        public int SnackId { get; set; }
        public Snack Snack { get; set; }
        public int SnackQuantity { get; set; }
        public bool Select { get; set; }
        public decimal Price { get; set; }
        public SnackOrder()
        {

        }
        public SnackOrder(int snackId)
        {
            SnackId = snackId;
        }
    }
}
