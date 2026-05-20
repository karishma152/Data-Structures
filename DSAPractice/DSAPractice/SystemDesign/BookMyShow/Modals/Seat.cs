using DSAPractice.SystemDesign.BookMyShow.Enums;

namespace DSAPractice.SystemDesign.BookMyShow.Modals
{
    public class Seat
    {
        public int _seatId { get; set; }
        public string SeatNumber { get; set; }
        public SeatCategoryEnum _seatCategory;
    }
}
