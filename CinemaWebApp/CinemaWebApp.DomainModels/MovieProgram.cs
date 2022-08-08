namespace CinemaWebApp.DomainModels
{
    public class MovieProgram
    {
        public int Id { get; set; }
        public CinemaHall CinemaHall { get; set; }
        public int CinemaHallId { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public decimal Price { get; set; }
        public MovieProgram()
        {

        }
        public MovieProgram(int cinemaHallId, DateTime date, string startTime, string endTime, decimal price)
        {
            CinemaHallId = cinemaHallId;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            Price = price;
        }
    }
}
