namespace CinemaWebApp.DomainModels
{
    public class Reservation
    {
        public int Id { get; set; }
        public MovieProgram MovieProgram { get; set; }
        public int MovieProgramId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<SnackOrder> SnackOrders { get; set; }
        public int TicketQuantity { get; set; }
        public decimal FullPrice { get; set; }
        public decimal SnackPrice { get; set; }
        public decimal TicketPrice { get; set; }

        public Reservation()
        {

        }
        public Reservation(int movieProgramId, string name, string lastName, decimal fullPrice, int id, int ticketQuantity, ICollection<SnackOrder> snackOrders)
        {
            MovieProgramId = movieProgramId;
            Name = name;
            LastName = lastName;
            FullPrice = fullPrice;
            Id = id;
            TicketQuantity = ticketQuantity;
            SnackOrders = snackOrders;
        }
    }
}
