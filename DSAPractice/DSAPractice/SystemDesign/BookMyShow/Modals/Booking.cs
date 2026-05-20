using DSAPractice.SystemDesign.BookMyShow.Enums;

namespace DSAPractice.SystemDesign.BookMyShow.Modals
{
    public class Booking
    {
        public int BookingId { get; set; }

        public User User { get; set; }

        public List<ShowSeat> Seats { get; set; }

        public BookingStatusEnum Status { get; set; }

        public Payment Payment { get; set; }
    }
}
