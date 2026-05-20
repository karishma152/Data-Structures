using System.Data;

namespace DSAPractice.SystemDesign.BookMyShow.Modals
{
    public class Screen
    {
        public int screenId { get; set; }
        public string screenName { get; set; }
        public List<Seat> seats { get; set; }
    }
}
