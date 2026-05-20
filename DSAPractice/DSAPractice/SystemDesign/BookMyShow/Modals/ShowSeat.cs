using DSAPractice.SystemDesign.BookMyShow.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.SystemDesign.BookMyShow.Modals
{
    public class ShowSeat
    {
        public int ShowSeatId { get; set; }
        public Seat Seat { get; set; }
        public SeatStatusEnum Status { get; set; }
    }
}
