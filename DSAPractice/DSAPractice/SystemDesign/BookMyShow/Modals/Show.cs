namespace DSAPractice.SystemDesign.BookMyShow.Modals
{
    public class Show
    {
        public int ShowId { get; set; }

        public DateTime StartTime { get; set; }

        public decimal Price { get; set; }

        public Movie Movie { get; set; }

        public Screen Screen { get; set; }

        public List<ShowSeat> ShowSeats { get; set; }
    }
}
